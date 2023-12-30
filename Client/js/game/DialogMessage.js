//local shop list needed for infoDiv
let shopDetails = [];

function getShopDetails(){
    return shopDetails
}

class DialogMessage {
    constructor({ text, faceHero, npcId, percent, shopItems, onComplete }) {
        this.percent = percent;
        this.text = text;
        this.faceHero = faceHero;
        this.npcId = npcId;
        this.shopItems = shopItems;
        this.onComplete = onComplete;
        this.element = null;
        this.tradeMenu = null;
        this.buttons = [];
        this.currentButtonIndex = 0;
    }

    createElement() {
        this.element = document.createElement("div");
        this.element.classList.add("TextMessage");

        this.element.innerHTML = `
            <h4 class="TextMessage-p">${this.faceHero}</h4>
            <p class="TextMessage-p">Greetings traveler!</p>
            ${this.text
                .map(
                    (textObj, index) => `
                <button class="TextMessage-button" id="${textObj.flag}"">${textObj.text}</button><br />
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
            this.currentButtonIndex =
                (this.currentButtonIndex + 1) % this.buttons.length;
            this.buttons[this.currentButtonIndex].focus();
        } else if (event.key === "ArrowUp" || event.key === "ArrowLeft") {
            event.preventDefault();
            this.currentButtonIndex =
                (this.currentButtonIndex - 1 + this.buttons.length) %
                this.buttons.length;
            this.buttons[this.currentButtonIndex].focus();
        }
    }

    async heal() {
        await app.put(apiBaseUrl + `Npc/heal?npcId=${this.npcId}`);
        updateHeroStatLabels();
    }

    async openTradeMenu(npcId) {
        this.element.remove();
        this.tradeMenu = document.createElement("div");
        this.tradeMenu.classList.add("tradeBox");
        console.log(this.shopItems)
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
        //console.log(this.tradeMenu)
        document.querySelector(".game-container").appendChild(this.tradeMenu);
        this.tradeMenu
            .querySelector("#tradeBox-close")
            .addEventListener("click", () => {
                shopDetails = [];
                this.closeTradeMenu();
            });
    }

    async fetchShopItems(npcId) {
        try {
            const fetchItemPromises = this.shopItems.map(async (item) => {
                const response = await app.get(apiBaseUrl + `Item?itemType=${item.itemType}&id=${item.itemId}`);
                const typePath = await this.itemTypeParser(item.itemType);
    
                const draggableDiv = $(`<div onmouseover="showItemInfo(this, event)" onmouseleave="hideItemInfo()" class="item-image" draggable="true" style="background-image: url('${typePath}${response.data.spriteURL}');"> </div>`);
    
                const itemWithSlot = {
                    itemDetails: response.data,
                    slotInfo: `${item.id}`,
                    npcId: npcId
                };
    
                shopDetails.push(itemWithSlot);
                $(`#s${item.id}`).append(draggableDiv);
                
            });
    
            await Promise.all(fetchItemPromises);
        } catch (error) {
            console.error("Error fetching item details:", error);
            throw error;
        }
    }
    
    async itemTypeParser(type) {
        switch(type) {
            case 0: return "./assets/primaryWeapons/";
            case 1: return "./assets/secondaryWeapons/";
            case 2: return "./assets/armors/";
            case 3: return "./assets/helmets/";
            case 4: return "./assets/boots/";
            case 5: return "./assets/gloves/";
            case 6: return "./assets/necklaces/";
            case 7: return "./assets/rings/";
            case 8: return "./assets/consumables/";
            case 9: return "./assets/neutrals/";
            case 10: return "./assets/quest/";
            default: return "";
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

    init(container) {
        this.createElement();
        container.appendChild(this.element);
    }
}
