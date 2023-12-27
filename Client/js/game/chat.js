const chatInput = document.getElementById('chat-post-message');
const gameCanvas = document.getElementById('game-canvas');

chatInput.addEventListener('keydown', (event) => {
    // Allow typing in the chat input field
    event.stopPropagation();
});

gameCanvas.addEventListener('keydown', (event) => {
    if (chatInput !== document.activeElement) {
        // Prevent keypress events in the game canvas if the chat input is not focused
        event.preventDefault();
    }
});