$(document).ready(function () {
    // Function to get character descriptions based on profession
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

    $("#hero\\.profession").change(function () {
        var selectedProfession = $(this).val();
        var characterDescription = getCharacterDescription(selectedProfession);
        $("#character-desc").text(characterDescription);

        $('.profession-image').removeClass('highlighted');
        $('.profession-image[data-profession="' + selectedProfession + '"]').addClass('highlighted');
    });


    $('.profession-image').hover(function () {
        var profession = $(this).data('profession');
        $('#character-desc').text(getCharacterDescription(profession));
        $('#hero\\.profession').val(profession).change();
    }, function () {
        $('#character-desc').text("Profession description will appear here.");
    });
});
