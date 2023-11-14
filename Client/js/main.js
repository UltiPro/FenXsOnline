const apiBaseUrl = "https://localhost:7180/";

const changeInputAudio = new Audio("./audio/input.wav");
const changeWindowAudio = new Audio("./audio/window.wav");
const unsuccessAudio = new Audio("./audio/unsuccess.wav");

const PlayChangeInputAudio = () => changeInputAudio.play();
const PlayChangeWindowAudio = () => changeWindowAudio.play();
const PlayUnsuccessAudio = () => unsuccessAudio.play();

$(document).ready(function () {
    $("input").bind("focus", PlayChangeInputAudio);
});

$(document).ready(function () {
    $("select").bind("change", PlayChangeInputAudio);
});
$(document).ready(function () {
    $("select").bind("focus", PlayChangeInputAudio);
});

