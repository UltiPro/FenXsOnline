$(document).ready(function () {
  $(".profession-image").click(function () {
    $(".profession-image").removeClass("clicked"); // Usunięcie flagi ze wszystkich
    $(this).addClass("clicked"); // dodanie flagi do klikniętego
  });

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

    $(".profession-image").removeClass("clicked");
    $(
      '.profession-image[data-profession="' + selectedProfession + '"]'
    ).addClass("clicked");
  });

  $(".profession-image").hover(
    function () {
      var profession = $(this).data("profession");
      $("#character-desc").text(getCharacterDescription(profession));
    },
    function () {
      $("#character-desc").text("Profession description will appear here.");
    }
  );

  $(".profession-image").click(function () {
    var profession = $(this).data("profession");
    $("#hero\\.profession").val(profession).change();
    highlightProfession(profession);
  });

  $("#hero\\.profession").change(function () {
    var selectedProfession = $(this).val();
    highlightProfession(selectedProfession);
    var selectedSex = $("#hero\\.sex").val();
    updateProfessionImages(selectedSex, selectedProfession);
  });

  function updateProfessionImages(sex, profession) {
    $(".profession-image").each(function () {
      var professionType = $(this).data("profession");
      var imageSrc = `./img/hero_preview/${professionType.toLowerCase()}_${sex.toLowerCase()}.gif`;
      $(this).attr("src", imageSrc);
    });
  }

  $("#hero\\.sex").change(function () {
    var selectedSex = $(this).val();
    var selectedProfession = $("#hero\\.profession").val();
    updateProfessionImages(selectedSex, selectedProfession);
  });
});
