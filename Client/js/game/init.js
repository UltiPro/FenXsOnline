function GameInit() {
    const overworld = new Overworld({
        element: document.querySelector(".game-container")
    });

    // Fetching time to respawn from localStorage
    const storedDeathTime = localStorage.getItem('deathTime');
    let respawnRemainingTime = 0;

    if (storedDeathTime) {
        const deathTime = parseInt(storedDeathTime, 10);
        respawnRemainingTime = Math.ceil((deathTime - Date.now()) / 1000);

        if (respawnRemainingTime > 0) {
            displayCountdown(overworld, respawnRemainingTime);
        } else {
            overworld.init();
        }
    } else {
        overworld.init();
    }

    window.overworldInstance = overworld;
}

function displayCountdown(overworld, remainingTime) {
	$('#equipment-container').css('pointer-events', 'none'); //disabling Equipment
    const blackOverlay = document.createElement('div');
    blackOverlay.classList.add('black-overlay');
    blackOverlay.id = 'black-overlay';
    document.querySelector('.game-container').appendChild(blackOverlay);
    blackOverlay.style.opacity = 1;

    const countdownElement = document.createElement('div');
    countdownElement.classList.add('countdown');
    countdownElement.textContent = `Respawn in ${remainingTime}s`;
    blackOverlay.appendChild(countdownElement);

    const countdownInterval = setInterval(() => {
        remainingTime--;
        countdownElement.textContent = `Respawn in ${remainingTime}s`;

        if (remainingTime < 0) {
            clearInterval(countdownInterval);
            blackOverlay.style.transition = 'opacity 0.5s ease-out';
            blackOverlay.style.opacity = 0;

            setTimeout(() => {
                blackOverlay.remove();
                localStorage.removeItem('deathTime'); // Clear the stored death time
				$('#equipment-container').css('pointer-events', 'auto'); //enabling equipment
                overworld.init(); // Initialize the game after countdown
            }, 500);
        }
    }, 1000);
}

