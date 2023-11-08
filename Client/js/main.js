const changeInputAudio = new Audio("./audio/input.wav");
const changeWindowAudio = new Audio("./audio/window.wav");
const unsuccessAudio = new Audio("./audio/unsuccess.wav");

const playChangeInputAudio = () => changeInputAudio.play();
const playChangeWindowAudio = () => changeWindowAudio.play();
const playUnsuccessAudio = () => unsuccessAudio.play();

$(document).ready(function () {
    $("input").bind("focus", playChangeInputAudio);
});