//local shop list needed for infoDiv
let shopDetails = [];

function getShopDetails() {
    return shopDetails;
}

class DialogMessage {
    constructor({ text, faceHero, npcId, percent, shopItems, quests, questsStage, mapRef, onComplete }) {
        this.percent = percent;
        this.text = text;
        this.faceHero = faceHero;
        this.npcId = npcId;
        this.shopItems = shopItems;
        this.quests = quests;
        this.questsStage = questsStage;
        this.map = mapRef;
        this.onComplete = onComplete;
        this.element = null;
        this.tradeMenu = null;
        this.buttons = [];
        this.currentButtonIndex = 0;
        this.alreadyDone = false;
    }

    createElement() {
        this.element = document.createElement("div");
        this.element.classList.add("TextMessage");
        this.element.innerHTML = `
            <h4 class="TextMessage-p">${this.faceHero}</h4>
            <p id="dialog" class="TextMessage-p">Greetings traveler!</p>
            ${this.text
                .map(
                    (textObj, index) => `
                <button class="TextMessage-button" id="${textObj.flag}">${textObj.text}</button><br />
            `
                )
                .join("")}
                
            <button id="close" class="TextMessage-button">I gotta go</button>
        `;

        this.buttons = this.element.querySelectorAll(".TextMessage-button");

        document.addEventListener("keydown", (event) => {
            this.handleArrowKeyPress(event);
        });

        this.buttons.forEach((button, index) => {
            button.addEventListener("click", (event) => {
                const id = event.target.id;

                switch (id) {
                    case "heal":
                        this.heal();
                        this.done();
                        break;
                    case "trade":
                        this.openTradeMenu(this.npcId);
                        //this.done();
                        break;
                    case "quest":
                        const npcMessage = document.getElementById("dialog");
                        npcMessage.textContent = this.quests[0].npcMessage;
                        this.questProgress()
                            .then((finished) => {
                                if (finished === true) {
                                    if (this.map.gameObjects[this.faceHero].talking[0].events[0].quests[0] !== undefined) {
                                        delete this.map.gameObjects[this.faceHero].talking[0].events[0].quests[0];
                                    }
                                    // Remove flag
                                    for (let i = 0; i < this.text.length; i++) {
                                        if (this.text[i].flag === "quest") {
                                            this.text.splice(i, 1);
                                            break; //exit loop if found
                                        }
                                    }
                                }
                            })
                            .catch((error) => {
                                console.error("Error in handling quest progress:", error);
                            });
                        break;
                    case "questStage":
                        this.talkQuest().then((success) => {
                            const npcMessage = document.getElementById("dialog");
                            if (success === true || alreadyDone === true) {
                                npcMessage.textContent = "Thank You very much, here is your reward.";
                                if (this.map.gameObjects[this.faceHero].talking[0].events[0].questsStage[0] !== undefined) {
                                    delete this.map.gameObjects[this.faceHero].talking[0].events[0].questsStage[0];
                                }
                                for (let i = 0; i < this.text.length; i++) {
                                    if (this.text[i].flag === "questStage") {
                                        this.text.splice(i, 1);
                                        break; //exit loop if found
                                    }
                                }
                                this.alreadyDone = true;
                            }
                            if (success === false) {
                                npcMessage.textContent = "This is not what I asked You for, come back here when You complete the task.";
                            }
                        });
                        break;
                    default:
                        this.done();
                        break;
                }
            });

            button.addEventListener("mouseenter", () => {
                this.currentButtonIndex = index;
                button.focus();
            });
        });

        setTimeout(() => {
            this.buttons[0].focus();
        }, 0); //after elements are rendered set default focus
    }
    //listing for arrow choice
    handleArrowKeyPress(event) {
        if (event.key === "ArrowDown" || event.key === "ArrowRight") {
            event.preventDefault();
            this.currentButtonIndex = (this.currentButtonIndex + 1) % this.buttons.length;
            this.buttons[this.currentButtonIndex].focus();
        } else if (event.key === "ArrowUp" || event.key === "ArrowLeft") {
            event.preventDefault();
            this.currentButtonIndex = (this.currentButtonIndex - 1 + this.buttons.length) % this.buttons.length;
            this.buttons[this.currentButtonIndex].focus();
        }
    }

    async heal() {
        await app.put(apiBaseUrl + `Npc/heal?npcId=${this.npcId}`);
        updateHeroStatLabels();
    }

    async questProgress() {
        try {
            await app.post(apiBaseUrl + `Quest/?questId=${this.quests[0].id}`);
            return true;
        } catch (error) {
            console.error("Error in quest progress:", error);
            return false;
        }
    }

    async talkQuest() {
        try {
            const response = await app.post(apiBaseUrl + `Quest/talk/?questId=${this.questsStage[0].questId}`);
            if (response.data.heroEquipmentRewards && response.data.heroEquipmentRewards.length > 0) {
                refreshHeroData();
                return true;
            } else {
                return false;
            }
        } catch (error) {
            console.error("Error talking to NPC:", error);
            return false;
        }
    }

    async questRefresh() {
        try {
            const response = await app.get(apiBaseUrl + "Map");
            let npcs = response.data.npCs;
            const thisNpc = npcs.find((npc) => npc.name === `${this.faceHero}`);

            if (thisNpc && thisNpc.quests && thisNpc.quests.length > 0) {
                thisNpc.quests.forEach((quest) => {
                    const isNewQuest = !this.quests.some((existingQuest) => existingQuest.title === quest.title);

                    if (isNewQuest) {
                        this.quests.push(quest);
                        this.text.push({
                            text: quest.title,
                            flag: "quest",
                        });
                    }
                });
            }

            if (thisNpc && thisNpc.questsStage && thisNpc.questsStage.length > 0) {
                thisNpc.questsStage.forEach((stage) => {
                    const isNewStage = !this.questsStage.some((existingStage) => existingStage.npcMessage === stage.npcMessage);

                    if (isNewStage) {
                        this.questsStage.push(stage);
                        this.text.push({
                            text: stage.npcMessage,
                            flag: "questStage",
                        });
                    }
                });
            }
        } catch (error) {
            console.error("Error with refreshing NPCs quest:", error);
        }
    }

    async openTradeMenu(npcId) {
        this.element.remove();
        this.tradeMenu = document.createElement("div");
        this.tradeMenu.classList.add("tradeBox");
        this.fetchShopItems(npcId);

        this.tradeMenu.innerHTML = `
            <span id="seller${this.npcId}" class="text-center"><h5 class="mt-2">${this.faceHero}</h5><h6>Selling rate: ${this.percent}</h6></span>
            <button id="tradeBox-close"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-x" viewBox="0 0 16 16">
            <path d="M.697 1.303a.75.75 0 0 1 1.06 0L8 6.94l6.243-6.637a.75.75 0 1 1 1.06 1.06L9.06 8l6.243 6.637a.75.75 0 1 1-1.06 1.06L8 9.06l-6.243 6.637a.75.75 0 1 1-1.06-1.06L6.94 8 .697 1.303z"/>
        </svg></button>
        <div id="shop" class="justify-content-center">
            <div class="row">
                <div id="s1" class="shop-slot col-2 col-sm-2"></div>
                <div id="s2" class="shop-slot col-2 col-sm-2"></div>
                <div id="s3" class="shop-slot col-2 col-sm-2"></div>
                <div id="s4" class="shop-slot col-2 col-sm-2"></div>
                <div id="s5" class="shop-slot col-2 col-sm-2"></div>
                <div id="s6" class="shop-slot col-2 col-sm-2"></div>
                <div class="w-100"></div>
                <div id="s7" class="shop-slot col-2 col-sm-2"></div>
                <div id="s8" class="shop-slot col-2 col-sm-2"></div>
                <div id="s9" class="shop-slot col-2 col-sm-2"></div>
                <div id="s10" class="shop-slot col-2 col-sm-2"></div>
                <div id="s11" class="shop-slot col-2 col-sm-2"></div>
                <div id="s12" class="shop-slot col-2 col-sm-2"></div>
                <div class="w-100"></div>
                <div id="s13" class="shop-slot col-2 col-sm-2"></div>
                <div id="s14" class="shop-slot col-2 col-sm-2"></div>
                <div id="s15" class="shop-slot col-2 col-sm-2"></div>
                <div id="s16" class="shop-slot col-2 col-sm-2"></div>
                <div id="s17" class="shop-slot col-2 col-sm-2"></div>
                <div id="s18" class="shop-slot col-2 col-sm-2"></div>
                <div class="w-100"></div>
                <div id="s19" class="shop-slot col-2 col-sm-2"></div>
                <div id="s20" class="shop-slot col-2 col-sm-2"></div>
                <div id="s21" class="shop-slot col-2 col-sm-2"></div>
                <div id="s22" class="shop-slot col-2 col-sm-2"></div>
                <div id="s23" class="shop-slot col-2 col-sm-2"></div>
                <div id="s24" class="shop-slot col-2 col-sm-2"></div>
                <div class="w-100"></div>
                <div id="s25" class="shop-slot col-2 col-sm-2"></div>
                <div id="s26" class="shop-slot col-2 col-sm-2"></div>
                <div id="s27" class="shop-slot col-2 col-sm-2"></div>
                <div id="s28" class="shop-slot col-2 col-sm-2"></div>
                <div id="s29" class="shop-slot col-2 col-sm-2"></div>
                <div id="s30" class="shop-slot col-2 col-sm-2"></div>
                <div class="w-100"></div>
                <div id="s31" class="shop-slot col-2 col-sm-2"></div>
                <div id="s32" class="shop-slot col-2 col-sm-2"></div>
                <div id="s33" class="shop-slot col-2 col-sm-2"></div>
                <div id="s34" class="shop-slot col-2 col-sm-2"></div>
                <div id="s35" class="shop-slot col-2 col-sm-2"></div>
                <div id="s36" class="shop-slot col-2 col-sm-2"></div>
                <div class="w-100"></div>
                <div id="s37" class="shop-slot col-2 col-sm-2"></div>
                <div id="s38" class="shop-slot col-2 col-sm-2"></div>
                <div id="s39" class="shop-slot col-2 col-sm-2"></div>
                <div id="s40" class="shop-slot col-2 col-sm-2"></div>
                <div id="s41" class="shop-slot col-2 col-sm-2"></div>
                <div id="s42" class="shop-slot col-2 col-sm-2"></div>
                <div class="w-100"></div>
                <div id="s43" class="shop-slot col-2 col-sm-2"></div>
                <div id="s44" class="shop-slot col-2 col-sm-2"></div>
                <div id="s45" class="shop-slot col-2 col-sm-2"></div>
                <div id="s46" class="shop-slot col-2 col-sm-2"></div>
                <div id="s47" class="shop-slot col-2 col-sm-2"></div>
                <div id="s48" class="shop-slot col-2 col-sm-2"></div>
            </div>
        </div>
         
        `;
        document.querySelector(".game-container").appendChild(this.tradeMenu);
        this.tradeMenu.querySelector("#tradeBox-close").addEventListener("click", () => {
            shopDetails = [];
            this.closeTradeMenu();
        });
    }

    async fetchShopItems(npcId) {
        try {
            for (const item of this.shopItems) {
                const response = await app.get(apiBaseUrl + `Item?itemType=${item.itemType}&id=${item.itemId}`);
                const typePath = await this.itemTypeParser(item.itemType);

                const draggableDiv = $(`<div onmouseover="showItemInfo(this, event)" onmouseleave="hideItemInfo()" class="item-image" draggable="true" style="background-image: url('${typePath}${response.data.spriteURL}');"> </div>`);

                const itemWithSlot = {
                    itemDetails: response.data,
                    slotInfo: `${item.id}`,
                    npcId: npcId,
                };

                shopDetails.push(itemWithSlot);
                $(`#s${item.id}`).append(draggableDiv);

                // Here, you might need to adjust the logic to add the item to the shopDetails list
                // using separate copies for each item in the shop.
                // Something like:
                for (let i = 0; i < 10; i++) {
                    // For example, adding 10 copies of each item to the shop
                    const clonedItem = { ...itemWithSlot };
                    shopDetails.push(clonedItem);
                }
            }
        } catch (error) {
            console.error("Error fetching item details:", error);
            throw error;
        }
    }

    async itemTypeParser(type) {
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
            default:
                return "";
        }
    }

    closeTradeMenu() {
        this.tradeMenu.remove();
        this.onComplete();
    }

    done() {
        this.element.remove();
        this.onComplete();
    }

    async init(container) {
        this.createElement();
        await this.questRefresh();
        container.appendChild(this.element);
    }
}
