$(document).ready(function () {
    $("#hero\\.profession").change(function () {
        var selectedProfession = $(this).val();
        var characterImagePath = getCharacterImagePath(selectedProfession);
        $("#character-image").attr("src", characterImagePath);
    });

    function getCharacterImagePath(profession) {
        switch (profession) {
            case "Paladin":
                return "./img/placeholder.png";
            case "Warrior":
                return "./img/placeholder.png";
            case "Mage":
                return "./img/placeholder.png";
            case "Hunter":
                return "./img/placeholder.png";
            default:
                return "./img/placeholder.png";
        }
    }
});