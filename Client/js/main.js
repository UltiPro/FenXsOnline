const apiBaseUrl = "https://localhost:7180/api/";
const apiBaseUrl_short = "https://localhost:7180/";

const app = axios.create({
    apiBaseUrl,
    withCredentials: true,
    headers: {
        'Cache-Control': 'no-cache',
    },
});

const changeInputAudio = new Audio("./audio/input.wav");
const changeWindowAudio = new Audio("./audio/window.wav");
const unsuccessAudio = new Audio("./audio/unsuccess.wav");
const music = new Audio("./audio/relaxingGreenNature.mp3")
let musicState = false

const PlayChangeInputAudio = () => changeInputAudio.play();
const PlayChangeWindowAudio = () => changeWindowAudio.play();
const PlayUnsuccessAudio = () => unsuccessAudio.play();
const PlayMusic = () => music.play();
const PauseMusic = () => music.pause();

$(document).ready(function () {
    if (devicePixelRatio == 1.25) document.body.style.zoom = 0.8;
    if (devicePixelRatio == 1.5) document.body.style.zoom = 0.667;
    if (devicePixelRatio == 1.75) document.body.style.zoom = 0.5715;
    if (devicePixelRatio == 2.0) document.body.style.zoom = 0.5;
    const playButton = $("#playButton");
    playButton.bind("click", function () {
        if (musicState === false) {
            PlayMusic();
            musicState = true;
            playButton.html('<i class="fas fa-pause"></i>');
        } else {
            PauseMusic();
            musicState = false;
            playButton.html('<i class="fas fa-play"></i>');
        }
    });
    music.addEventListener('ended', function() {
        music.currentTime = 0;
        music.play();
    });
    $("input").attr("autocomplete", "off");
    $("input").bind("focus", PlayChangeInputAudio);
    $("select").bind("click", PlayChangeInputAudio);
    $("select").bind("change", PlayChangeInputAudio);
    $(".character-slot").bind("click", PlayChangeInputAudio);
});
