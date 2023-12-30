let itemDetailsListBP = []; // Declare an array to store item details
let itemDetailsListEQ = []

function getEquipmentDetails(){
    return itemDetailsListEQ
}

function setEquipmentDetails(updatedItemList) {
    itemDetailsListEq = updatedItemList;
}

function getBackpackDetails(){
   return itemDetailsListBP
}

function setBackpackDetails(updatedItemList) {
    itemDetailsListBP = updatedItemList;
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
    const bp = response.data.heroEquipment;

    updateHeroStats(heroData);
    updateHeroBackpack(bp);
    updateHeroEquipment(heroData);
}

async function updateHeroStatLabels(){
    app.get(apiBaseUrl + "Hero/").then((response) =>{
        updateHeroStats(response.data)
    })
    .catch(err => {console.log("Error with updating hero statistic labels"), err})
}

//Updating stat labels
function updateHeroStats(heroData) {
    $("#dmg\\.value").text(heroData.attack);
    $("#def\\.value").text(heroData.armor);
    $("#health\\.value").text(heroData.healthPoints + "/" + heroData.maxHealthPoints);
    $("#m-dmg\\.value").text(heroData.magicAttack);
    $("#m-def\\.value").text(heroData.magicArmor);
    $("#mana\\.value").text(heroData.mana + "/" + heroData.maxMana);
    $("#agility\\.value").text(heroData.agility);
    $("#gold\\.value").text(heroData.gold);
    $("#stamina\\.value").text(heroData.stamina + "/" + heroData.maxStamina);
}

function getItemDetails(item) {
    return app.get(apiBaseUrl + `Item?itemType=${item.itemType}&id=${item.itemId}`)
        .then(function (response) {
            var type = itemTypeParser(item.itemType)
            //create div with item
            var draggableDiv = $(`<div onmouseover="showItemInfo(this, event)" onmouseleave="hideItemInfo()" class="item-image" draggable="true" style="background-image: url('${type}${response.data.spriteURL}');"> </div>`);
            $(`#s${item.id}`).append(draggableDiv);

            //asigning data about which slot it is in backpack
            const itemWithSlot = {
                itemDetails: response.data,
                slotInfo: `${item.id}`
            };
            //console.log(itemWithSlot)
            itemDetailsListBP.push(itemWithSlot);
            
            return response.data;
          
        })
        .catch(function (error) {
            console.error("Error fetching item details:", error);
            throw error;
        });
}

// ForEach item get it's data
async function updateHeroBackpack(bp) {
    const promises = bp
        .filter(item => item && item.itemType !== null && item.itemId !== null)
        .map(await getItemDetails);
}

//Loading Hero Equipment
function updateHeroEquipment(heroData) {
    for (const key in heroData) {
        if (key.startsWith('db') && heroData[key] !== null) {
            const parsedKey = parseEqId(key);
            
            const itemWithSlot = {
                itemDetails: heroData[key],
                slotInfo: `${parsedKey}`
            };

            const itemType = itemWithSlot.itemDetails.itemType;
            const spriteURL = itemWithSlot.itemDetails.spriteURL;

            //console.log(itemType, spriteURL)
            let type = itemTypeParser(itemType);
            let response = { data: { spriteURL: spriteURL } }; 
        
            let draggableDiv = $(`<div onmouseover="showItemInfo(this, event)" onmouseleave="hideItemInfo()" class="item-image" draggable="true" style="background-image: url('${type}${response.data.spriteURL}');"> </div>`);
            $(`#${key}`).empty().append(draggableDiv);

            //console.log(itemWithSlot);
            itemDetailsListEQ.push(itemWithSlot);
            //UpdateHeroStatLabels();
        }
    }
}

function itemTypeParser(type){
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

function getHeroSpritePath(profession){
    switch(profession){
        case 0: return "./assets/heroes/warrior/"
        case 1: return "./assets/heroes/hunter/"
        case 2: return "./assets/heroes/mage/"
        case 3: return "./assets/heroes/paladin/"
    }
}
