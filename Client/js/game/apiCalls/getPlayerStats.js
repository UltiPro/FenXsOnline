let itemDetailsListBP = []; // Declare an array to store item details
let itemDetailsListEQ = [];
let questListDet = [];

function getEquipmentDetails() {
    return itemDetailsListEQ;
}

function setEquipmentDetails(updatedItemList) {
    itemDetailsListEq = updatedItemList;
}

function getBackpackDetails() {
    return itemDetailsListBP;
}

function setBackpackDetails(updatedItemList) {
    itemDetailsListBP = updatedItemList;
}

function getQuestDetails(){
    return questListDet;
}

function setQuestDetails(updatedQuestList) {
    questListDet = updatedQuestList;
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

async function updateHeroStatLabels() {
    app.get(apiBaseUrl + "Hero/")
        .then((response) => {
            updateHeroStats(response.data);
        })
        .catch((err) => {
            console.log("Error with updating hero statistic labels"), err;
        });
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
    $("#name-level-profession").text(heroData.name + " lvl: " + heroData.level + " " +parseProfession(heroData.profession))
}

function getItemDetails(item) {
    return app
        .get(apiBaseUrl + `Item?itemType=${item.itemType}&id=${item.itemId}`)
        .then(function (response) {
            const type = itemTypeParser(item.itemType);
            //create div with item
            const draggableDiv = $(`<div onmouseover="showItemInfo(this, event)" onmouseleave="hideItemInfo()" class="item-image" draggable="true" style="background-image: url('${type}${response.data.spriteURL}');"> </div>`);
            $(`#s${item.id}`).append(draggableDiv);

            //asigning data about which slot it is in backpack
            const itemWithSlot = {
                itemDetails: response.data,
                slotInfo: `${item.id}`,
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
    const promises = bp.filter((item) => item && item.itemType !== null && item.itemId !== null).map(await getItemDetails);
}

//Loading Hero Equipment
function updateHeroEquipment(heroData) {
    for (const key in heroData) {
        if (key.startsWith("db") && heroData[key] !== null) {
            const parsedKey = parseEqId(key);

            const itemWithSlot = {
                itemDetails: heroData[key],
                slotInfo: `${parsedKey}`,
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

let questBoxExists = false;
    async function showQuestList() {
        if (!questBoxExists) {
            await app.get(apiBaseUrl + `Quest`).then((response) => {
                console.log(response.data);
                let questList = document.createElement("div");
                questList.classList.add("questBox");
                questList.innerHTML = `
                    <span id="questMenu" class="text-center"><h5 class="mt-2">Quest List</h5></span>
                    <button id="questBox-close"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-x" viewBox="0 0 16 16">
                        <path d="M.697 1.303a.75.75 0 0 1 1.06 0L8 6.94l6.243-6.637a.75.75 0 1 1 1.06 1.06L9.06 8l6.243 6.637a.75.75 0 1 1-1.06 1.06L8 9.06l-6.243 6.637a.75.75 0 1 1-1.06-1.06L6.94 8 .697 1.303z"/>
                    </svg></button>
                    <div id="questList">
                        <div id="questListTitles"></div>
                        <div id="questListDesc"></div>
                    </div>
                `;

                document.querySelector(".game-container").appendChild(questList);
                questList.querySelector("#questBox-close").addEventListener("click", () => {
                    questList.remove();
                    questBoxExists = false; // Reset the flag when the questBox is removed
                });
                const titlesContainer = questList.querySelector("#questListTitles");
                const descContainer = questList.querySelector("#questListDesc");
                let activeTitle = null;

                //adding quests
                response.data.forEach((quest) => {
                    const titleElement = document.createElement("div");
                    titleElement.classList.add("questTitle");
                    titleElement.textContent = quest.title;

                    // Event to change color
                    titleElement.addEventListener("click", () => {
                        if (activeTitle) {
                            activeTitle.style.color = 'goldenrod'; //switch back
                        }

                        titleElement.style.color = 'white'; // active
                        activeTitle = titleElement; // Store the current active title

                        // Description after click
                        descContainer.innerHTML = "";
                        const descElement = document.createElement("div");
                        descElement.classList.add("questDesc");
                        descElement.textContent = quest.description;
                        descContainer.appendChild(descElement);
                    });

                    titlesContainer.appendChild(titleElement);
                });
                questBoxExists = true; //QuestBox exists
            });
        }
    }

function itemTypeParser(type) {
    switch (type) {
        case 0:
            return "./assets/primaryWeapons/";
        case 1:
            return "./assets/secondaryWeapons/";
        case 2:
            return "./assets/armors/";
        case 3:
            return "./assets/helmets/";
        case 4:
            return "./assets/boots/";
        case 5:
            return "./assets/gloves/";
        case 6:
            return "./assets/necklaces/";
        case 7:
            return "./assets/rings/";
        case 8:
            return "./assets/consumables/";
        case 9:
            return "./assets/neutrals/";
        case 10:
            return "./assets/quest/";
    }
}

function getHeroSpritePath(profession) {
    switch (profession) {
        case 0:
            return "./assets/heroes/warrior/";
        case 1:
            return "./assets/heroes/hunter/";
        case 2:
            return "./assets/heroes/mage/";
        case 3:
            return "./assets/heroes/paladin/";
    }
}