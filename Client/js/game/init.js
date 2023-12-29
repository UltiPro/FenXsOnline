function GameInit(){
		const overworld = new Overworld({
			element: document.querySelector(".game-container")
		});
		overworld.init();
		window.overworldInstance = overworld;
}

/* this function initiate the game
probably will be used after successful
user login identification */