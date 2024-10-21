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

function ClearAlerts() {
    $("#alert-error").hide();
    $("#alert-error-message").text("");
    $("#alert-success").hide();
    $("#alert-success-message").text("");
}

function SetCookie(name) {
    document.cookie = name + "=" + encodeURIComponent(name) + "; max-age=" + 31536000;
}

function GetCookie(name) {
    const parts = `; ${document.cookie}`.split(`; ${name}=`);
    if (parts.length === 2) return parts.pop().split(";").shift();
}

function ErrorMessage(error, login = false) {
    let message = "";
    if (error.response.data.errors) {
        for (const key of Object.keys(error.response.data.errors)) {
            for (const errorMessage of error.response.data.errors[key]) message += "\n" + errorMessage;
        }
        $("#alert-error-message").text(message);
    } else if (error.response.data.Message) {
        message = error.response.data.Message;
    } else if (error.response.data) {
        for (const key of Object.keys(error.response.data)) {
            for (const errorMessage of error.response.data[key]) message += "\n" + errorMessage;
        }
    } else if (error.response.status == 401 && login) {
        message = "Incorrect Login or Password.";
    } else message = "Internal server error. Please try again later.";
    $("#alert-error-message").text(message);
    $("#alert-error").show();
}

$(document).ready(function () {
    if (GetCookie("whereLogged")) ToggleBox("#selector-register", "#selector-login", "#menu-register", "#menu-login", false);
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
    $("#alert-success button").bind("click", () => {
        $("#alert-success").hide();
    });
    $("#alert-error button").bind("click", () => {
        $("#alert-error").hide();
    });
    $("#form-register").bind("submit", function (e) {
        e.preventDefault();
        if (!ValidateRegister()) return;
        ClearAlerts();
        axios.post(apiBaseUrl + "Account/register", {
            Login: $("input[id='r.login']").val(),
            Email: $("input[id='r.email']").val(),
            Password: $("input[id='r.password']").val(),
        }).then(_ => {
            $("#alert-success-message").text("Your account has been created.");
            $("#alert-success").show();
        }, error => ErrorMessage(error));
    });
    $("#form-login").bind("submit", function (e) {
        e.preventDefault();
        if (!ValidateLogin()) return;
        ClearAlerts();
        app.post(apiBaseUrl + "Account/login", {
            Login: $("input[id='l.login']").val(),
            Password: $("input[id='l.password']").val(),
        }).then(_ => {
            SetCookie("whereLogged");
            window.location.replace("./start.html");
        }, error => ErrorMessage(error, true));
    });
});