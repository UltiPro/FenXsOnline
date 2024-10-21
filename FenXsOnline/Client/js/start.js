$(document).ready(function () {
    $(".profession-image").click(function () {
        $(".profession-image").removeClass("clicked"); // Usunięcie flagi ze wszystkich
        $(this).addClass("clicked"); // dodanie flagi do klikniętego
    });
    //opisy profesji
    function getCharacterDescription(profession) {
        switch (profession) {
            case "Paladin":
                return "The noble Paladin upholds justice and protects the weak with their righteous powers.";
            case "Warrior":
                return "Warrior relies on their muscle strength. They have the highest amount of health points among all professions. Specializes in close melee combat.";
            case "Mage":
                return "The powerful Mage harnesses arcane energies to cast devastating spells and control the elements.";
            case "Hunter":
                return "Hunters are based primarily on speed, agility, and precision. They are Long-Range Combat Specialists armed with a bow and quivers of arrows.";
            default:
                return "No description available.";
        }
    }

    //obsługa kliknięć i update ilustracji zależnie od płci
    $("#hero\\.profession").change(function () {
        var selectedProfession = $(this).val();
        var selectedSex = $("#hero\\.sex").val();
        var characterDescription = getCharacterDescription(selectedProfession);
        updateProfessionImages(selectedSex, selectedProfession);
        $("#character-desc").text(characterDescription);

        $(".profession-image").removeClass("clicked");
        $('.profession-image[data-profession="' + selectedProfession + '"]').addClass("clicked");
    });

    //zmiana opisu po najechaniu myszą na sprite
    $(".profession-image").hover(
        function () {
            var profession = $(this).data("profession");
            $("#character-desc").text(getCharacterDescription(profession));
        },
        function () {
            $("#character-desc").text("Profession description will appear here.");
        }
    );

    //zmiana profesji po kliknięciu
    $(".profession-image").click(function () {
        var profession = $(this).data("profession");
        $("#hero\\.profession").val(profession).change();
    });

    //zmiana spritów na podstawie płci
    function updateProfessionImages(sex, profession) {
        $(".profession-image").each(function () {
            var professionType = $(this).data("profession");
            sex = sex || "male";
            var imageSrc = `./img/hero_preview/${professionType.toLowerCase()}_${sex.toLowerCase()}.gif`;
            $(this).attr("src", imageSrc);
        });
    }

    $("#hero\\.sex").change(function () {
        var selectedSex = $(this).val();
        var selectedProfession = $("#hero\\.profession").val();
        updateProfessionImages(selectedSex, selectedProfession);
    });

    function handleSlotClick(clickedElement) {
        var slotId = clickedElement.attr("id") || clickedElement.attr("1");
        $(".character-slot").removeClass("selected bg-wooden").addClass("bg-darkwooden");
        clickedElement.removeClass("bg-darkwooden").addClass("selected bg-wooden");

        app.get(apiBaseUrl + "Hero/all").then(
            (response) => {
                let heroInfo = response.data[parseInt(slotId.slice(-1)) - 1];
                if (heroInfo === undefined) {
                    $("#menu-character-present").toggle(!slotId.startsWith("selector"));
                    $("#menu-character-creation").toggle(slotId.startsWith("selector"));
                } else {
                    $("input[name='hero.id']").val(heroInfo.id);
                    $("#readNick").text(heroInfo.name);
                    $("#readProfession").text(professionParser(heroInfo.profession));
                    $("#readSex").text(sexParser(heroInfo.sex));
                    $("#readLevel").text(heroInfo.level);
                    $("#readHealth").text(heroInfo.maxHealthPoints);
                    $("#readStamina").text(heroInfo.maxStamina);
                    $("#readMana").text(heroInfo.maxMana);

                    $("#menu-character-present").toggle(slotId.startsWith("selector"));
                    $("#menu-character-creation").toggle(!slotId.startsWith("selector"));
                }
            },
            (error) => {
                console.log("Connection error or Forbidden!");
            }
        );
    }

    function professionParser(profession) {
        switch (profession) {
            case 0:
                return "Warrior";
            case 1:
                return "Hutner";
            case 2:
                return "Mage";
            case 3:
                return "Paladin";
        }
    }

    function sexParser(sex) {
        switch (sex) {
            case 0:
                return "Male";
            case 1:
                return "Female";
        }
    }

    var typingTimer;
    var doneTypingInterval = 1000;
    $("#hero\\.nick").keyup(function () {
        clearTimeout(typingTimer);
        if ($("input[id='hero.nick']").val()) {
            typingTimer = setTimeout(ValidateNickname, doneTypingInterval);
        }
    });

    function ValidateNickname() {
        let valid = true;
        valid = Validation(nicknameRegex, $("input[id='hero.nick']"), valid);
        if (!valid) PlayUnsuccessAudio();
        return valid;
    }

    //handlery slotow
    $(".character-slot").ready(function () {
        handleSlotClick($(".character-slot").first());
    });

    $(".character-slot").click(function () {
        handleSlotClick($(this));
    });

    //wysłanie formularza tworzenia postaci
    $("#form-create-hero").bind("submit", function (e) {
        e.preventDefault();
        app.post(apiBaseUrl + "Hero", {
            name: $("input[id='hero.nick']").val(),
            profession: CreationConvertProfession($("select[id='hero.profession']").val()),
            sex: CreationConvertSex($("select[id='hero.sex']").val()),
        }).then(
            (_) => {
                $("#hero-created-message").text("Your hero has just been created! You're one step ahead of your adventure!");
                $("#alert-hero-created").show();
                setTimeout(function () {
                    $("#alert-hero-created").hide();
                }, 3000);
                $(".profession-image").removeClass("clicked");
                $("input[id='hero.nick']").val('');
                $("select[id='hero.profession']").val('');
                $("select[id='hero.sex']").val('');
                handleSlotClick($(".character-slot.selected"));
            },
            (error) => {
                $("#nick-exists-message").text("Hero with this nickname already exists!");
                $("#alert-nick-exists").show();
                console.log("Error create hero!");
            }
        );
    });

    $("#alert-nick-exists button").bind("click", () => {
        $("#alert-nick-exists").hide();
    });

    $("#alert-hero-created button").bind("click", () => {
        $("#alert-hero-created").hide();
    });

    $("#form-delete-hero").bind("submit", function (e) {
        e.preventDefault();
        var deleteId = $("input[name='hero.id']").val();
        if (deleteId) {
            app.delete(apiBaseUrl + "Hero?id=" + deleteId)
                .then((response) => {
                    $("#hero-delete-message").text("This character has just been deleted.");
                    $("#alert-hero-delete").show();
                    setTimeout(function () {
                        $("#alert-hero-delete").hide();
                    }, 3000);
                    $(".profession-image").removeClass("clicked");
                    $("input[id='hero.nick']").val('');
                    $("select[id='hero.profession']").val('');
                    $("select[id='hero.sex']").val('');
                    handleSlotClick($(".character-slot.selected"));
                })
                .catch((error) => {
                    console.error("Error deleting item:", error);
                });
        } else {
            console.error("No deleteId provided");
        }
    });

    $("#alert-hero-delete button").bind("click", () => {
        $("#alert-hero-delete").hide();
    });

    //wysłanie informacji do serwera, która postać została wybrana
    $("#form-play").on("submit", function (e) {
        e.preventDefault();
        var playId = $("input[name='hero.id']").val();

        app.put(apiBaseUrl + "Hero/play?id=" + playId)
            .then((response) => {
                sessionStorage.setItem("heroId", playId);
                window.location.replace("./game.html");
            })
            .catch((error) => {
                console.error("Error with throwing character into the game", error);
            });
    });

    $('#logout-button').bind("click", () => {
        app.post(apiBaseUrl + "Account/logout")
            .then(() => {
                window.location.replace("./index.html");
            })
            .catch((error) => {
                console.error("Error logging out:", error);
            });
    });

    //sex: string -> int
    function CreationConvertSex(sex) {
        if (sex == "Male") {
            return 0;
        } else {
            return 1;
        }
    }

    //profession: string -> int
    function CreationConvertProfession(profession) {
        switch (profession) {
            case "Warrior":
                return 0;
            case "Hunter":
                return 1;
            case "Mage":
                return 2;
            case "Paladin":
                return 3;
            default:
                return 0;
        }
    }
});