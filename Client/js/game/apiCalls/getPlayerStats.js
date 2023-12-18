let itemDetailsList = []; // Declare an array to store item details

function GetBackpackDetails(){
   return itemDetailsList
}

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
    const heroData = response.data;
    const eq = response.data.heroEquipment;

    UpdateHeroStats(heroData);
    UpdateHeroBackpack(eq);
    UpdateHeroEquipment();
}

async function UpdateHeroStatLabels(){
    app.get(apiBaseUrl + "Hero/").then((response) =>{
        UpdateHeroStats(response.data)
    })
    .catch(err => {console.log("Error with updating hero statistic labels"), err})
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
            $(`#s${item.id}`).append(draggableDiv);

            //asigning data about which slot it is in backpack
            const itemWithSlot = {
                itemDetails: response.data,
                slotInfo: `${item.id}`
            };
            //console.log(itemWithSlot)
            itemDetailsList.push(itemWithSlot);
            
            return response.data;
          
        })
        .catch(function (error) {
            console.error("Error fetching item details:", error);
            throw error;
        });
}

// ForEach item get it's data
function UpdateHeroBackpack(eq) {
    const promises = eq
        .filter(item => item && item.itemType !== null && item.itemId !== null)
        .map(GetItemDetails);
}

//
function UpdateHeroEquipment(){

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

