$(document).ready(function () {
    $("#hero\\.profession").change(function () {
        var selectedProfession = $(this).val();
        var characterImagePath = getCharacterImagePath(selectedProfession);
        var characterDescription = getCharacterDescription(selectedProfession);

        $("#character-image").attr("src", characterImagePath);
        $("#character-desc").text(characterDescription);
    });

    function getCharacterImagePath(profession) {
        switch (profession) {
            case "Paladin":
                return "./img/hero_preview/paladin_menu.gif";
            case "Warrior":
                return "./img/hero_preview/warrior_menu.gif";
            case "Mage":
                return "./img/hero_preview/mage_menu.gif";
            case "Hunter":
                return "./img/hero_preview/hunter_menu.gif";
            default:
                return "./img/logo.png";
        }
    }

    function getCharacterDescription(profession) {
        switch (profession) {
            case "Paladin":
                return "The noble Paladin upholds justice and protects the weak with their righteous powers.";
            case "Warrior":
                return "Warrior rely on their muscle strength. He has the highest amout of health points among all professions. Specializes in close malee combat";
            case "Mage":
                return "The powerful Mage harnesses arcane energies to cast devastating spells and control the elements.";
            case "Hunter":
                return "Hunter is based primarily on speed, agility and precision. Long-Range Combat Specialists armed with a bow and quivers of arrows.";
            default:
                return "No description available.";
        }
    }


    
});