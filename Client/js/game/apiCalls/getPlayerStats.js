const exportedEqData = [];

$(document).ready(function () {
    fetchHeroData();
});

function fetchHeroData() {
    app.get(apiBaseUrl + "Hero/")
        .then(processHeroData)
        .catch(function (error) {
            console.error("Error fetching hero stats:", error);
        });
}

function processHeroData(response) {
    response.data.agility = 5;
    response.data.gold = 100;
    const heroData = response.data;
    const eq = response.data.heroEquipment;

    UpdateHeroStats(heroData);
    UpdateHeroBackpack(eq);
}

//Updating stat labels
function UpdateHeroStats(heroData) {
    $("#dmg\\.value").text(heroData.atack);
    $("#def\\.value").text(heroData.armor);
    $("#health\\.value").text(heroData.healthPoints + "/" + heroData.maxHealthPoints);
    $("#m-dmg\\.value").text(heroData.magicAtack);
    $("#m-def\\.value").text(heroData.magicArmor);
    $("#mana\\.value").text(heroData.mana + "/" + heroData.maxMana);
    $("#agility\\.value").text(heroData.agility);
    $("#gold\\.value").text(heroData.gold);
    $("#stamina\\.value").text(heroData.stamina + "/" + heroData.maxStamina);
}

function GetItemDetails(item) {
    return app.get(apiBaseUrl + `Item?itemType=${item.itemType}&id=${item.itemId}`)
        .then(function (response) {
            var type = ItemTypeParser(item.itemType)
            //create div with item
            var draggableDiv = $(`<div class="item-image" draggable="true" style="background-image: url('${type}${response.data.spriteURL}');"> </div>`);
            //console.log(type)
            $(`#s${item.id}`).append(draggableDiv);
            
            return response.data;
          
        })
        .catch(function (error) {
            console.error("Error fetching item details:", error);
            throw error;
        });
}

// Inside UpdateHeroBackpack function
function UpdateHeroBackpack(eq) {
    const promises = eq
        .filter(item => item && item.itemType !== null && item.itemId !== null)
        .map(GetItemDetails);

    Promise.all(promises)
        .then(function (itemDetails) {
            exportedEqData.push(...itemDetails);
            // Any further processing with exportedEqData or other logic can be placed here
        })
        .catch(function (error) {
            console.error("Error fetching item details for backpack:", error);
        });
}

function ItemTypeParser(type){
    switch(type){
        case 0: return "./assets/primaryWeapons/"
        case 1: return "./assets/secondaryWeapons/"
        case 2: return "./assets/armors/"
        case 3: return "./assets/helmets/"
        case 4: return "./assets/boots/"
        case 5: return "./assets/gloves/"
        case 6: return "./assets/necklaces/"
        case 7: return "./assets/rings/"
        case 8: return "./assets/consumables/"
        case 9: return "./assets/neutrals/"
        case 10: return "./assets/quest/"
    }
    
}

