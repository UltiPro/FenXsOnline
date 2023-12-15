$(document).ready(function () {
  fetchHeroStats();
  });

function fetchHeroStats() {
    app.get(apiBaseUrl + "Hero/")
      .then(function (response) {
        //return response.data;
        
        //update hero stats
        $('#dmg\\.value').text(response.data.atack);
        $('#def\\.value').text(response.data.armor);
        $('#health\\.value').text(response.data.healthPoints+"/"+response.data.maxHealthPoints);
        $('#m-dmg\\.value').text(response.data.magicAtack);
        $('#m-def\\.value').text(response.data.magicArmor);
        $('#mana\\.value').text(response.data.mana+"/"+response.data.maxMana);
        $('#agility\\.value').text(response.data.agility);
        $('#gold\\.value').text(response.data.gold);
        $('#stamina\\.value').text(response.data.stamina+"/"+response.data.maxStamina);
      })
      .catch(function (error) {
        console.error('Error fetching hero stats:', error);
      });
  }