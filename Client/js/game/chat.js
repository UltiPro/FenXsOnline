const chatInput = document.getElementById('chat-message');
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

$(document).ready(async function () {
    const chatConnection = new signalR.HubConnectionBuilder().withUrl(apiBaseUrl_short + "chat").build();

    await chatConnection.start().catch(error => console.error(error.toString()));

    chatConnection.on("ReceiveMessage", (nick, message) => {
        $("#chat-all-messages").append(`<li><span>${nick}:</span> ${message}</li>`);
    });

    $("#chat").on("submit", event => {
        event.preventDefault();

        if ($("#chat-message").val().length == 0) return;

        chatConnection.invoke("SendMessage", $("#chat-message").val()).catch(error => {
            return console.error(error.toString());
        });
    });
});
