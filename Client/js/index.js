function ToggleBox(fromSelector, toSelector, fromBox, toBox, playAudio) {
    if ($(toSelector).hasClass("bg-darkwooden")) {
        if (playAudio) PlayChangeWindowAudio();
        $(fromBox).hide();
        $(fromSelector).removeClass("bg-wooden");
        $(fromSelector).addClass("bg-darkwooden");
        $(toBox).show();
        $(toSelector).removeClass("bg-darkwooden");
        $(toSelector).addClass("bg-wooden");
        switch (toSelector) {
            case "#selector-login":
                $(fromSelector).addClass("border-start-0");
                $(toSelector).removeClass("border-end-0");
                break;
            case "#selector-register":
                $(fromSelector).addClass("border-end-0");
                $(toSelector).removeClass("border-start-0");
                break;
        }
    }
}

function ToggleInfo(fromBox, toBox) {
    PlayChangeWindowAudio();
    $(fromBox).hide();
    $(toBox).show();
}

function ValidateRegister() {
    let valid = true;
    valid = Validation(loginRegex, $("input[id='r.login']"), valid);
    valid = Validation(emailRegex, $("input[id='r.email']"), valid);
    valid = Validation(passwordRegex, $("input[id='r.password']"), valid);
    valid = CheckPasswords($("input[id='r.password']"), $("input[id='r.c_password']"), valid);
    if (!valid) PlayUnsuccessAudio();
    return valid;
}

function ValidateLogin() {
    let valid = true;
    valid = Validation(loginRegex, $("input[id='l.login']"), valid);
    valid = Validation(passwordRegex, $("input[id='l.password']"), valid);
    if (!valid) PlayUnsuccessAudio();
    return valid;
}

function GetCookie(name) {
    const value = `; ${document.cookie}`;
    const parts = value.split(`; ${name}=`);
    if (parts.length === 2) return parts.pop().split(';').shift();
}

$(document).ready(function () {
    if (GetCookie("whereLogged") != null) ToggleIndexBox("#selector-register", "#selector-login", "#menu-register", "#menu-login", false);
    $("#selector-register").bind("click", function () {
        ToggleBox("#selector-login", "#selector-register", "#menu-login", "#menu-register", true);
    });
    $("#selector-login").bind("click", function () {
        ToggleBox("#selector-register", "#selector-login", "#menu-register", "#menu-login", true);
    });
    $("#menu-register-info").bind("click", function () {
        ToggleInfo("#menu", "#menu-info");
    });
    $("#menu-info-quit").bind("click", function () {
        ToggleInfo("#menu-info", "#menu");
    });
    $("#form-register").bind("submit", function (e) {
        e.preventDefault();
        if (!ValidateRegister()) return;
    });
    $("#form-login").bind("submit", function (e) {
        e.preventDefault();
        if (!ValidateLogin()) return;
    });
});