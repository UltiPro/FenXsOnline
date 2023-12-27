const apiBaseUrl = "https://localhost:7180/api/";
const apiBaseUrl_short = "https://localhost:7180/";

const app = axios.create({
  apiBaseUrl,
  withCredentials: true,
});

const changeInputAudio = new Audio("./audio/input.wav");
const changeWindowAudio = new Audio("./audio/window.wav");
const unsuccessAudio = new Audio("./audio/unsuccess.wav");

const PlayChangeInputAudio = () => changeInputAudio.play();
const PlayChangeWindowAudio = () => changeWindowAudio.play();
const PlayUnsuccessAudio = () => unsuccessAudio.play();

$(document).ready(function () {
  if (devicePixelRatio == 1.25) document.body.style.zoom = 0.8;
  if (devicePixelRatio == 1.50) document.body.style.zoom = 0.667;
  if (devicePixelRatio == 1.75) document.body.style.zoom = 0.5715;
  if (devicePixelRatio == 2.00) document.body.style.zoom = 0.5;
  $("input").bind("focus", PlayChangeInputAudio);
  $("select").bind("click", PlayChangeInputAudio);
  $("select").bind("change", PlayChangeInputAudio);
  $(".character-slot").bind("click", PlayChangeInputAudio);
});
