class DialogMessage {
    constructor({ text, faceHero, npcId, onComplete }) {
        this.text = text;
        this.faceHero = faceHero;
        this.npcId = npcId;
        this.onComplete = onComplete;
        this.element = null;
        this.tradeMenu = null;
        this.buttons = [];
        this.currentButtonIndex = 0;
    }

    createElement() {
        this.element = document.createElement("div");
        this.element.classList.add("TextMessage");
    
        this.element.innerHTML = (`
            <h4 class="TextMessage-p">${this.faceHero}</h4>
            <p class="TextMessage-p">Greetings traveler!</p>
            ${this.text.map((textObj, index) => `
                <button class="TextMessage-button" id="${textObj.flag}"">${textObj.text}</button><br />
            `).join('')}
            <button id="close" class="TextMessage-button">I gotta go</button>
        `);
    
        this.buttons = this.element.querySelectorAll(".TextMessage-button");
    
        document.addEventListener("keydown", (event) => {
            this.handleArrowKeyPress(event);
        });
    
        this.buttons.forEach((button) => {
            button.addEventListener("click", (event) => {
                const id = event.target.id;
                
                switch (id) {
                    case "heal":
                        this.heal();
                        this.done();
                        break;
                    case "trade":
                        this.openTradeMenu();
                        //this.done();
                        break;
                        
                    default:
                        this.done();
                        break;
                }
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

    async heal(){
        await app.put(apiBaseUrl + `Npc/heal?npcId=${this.npcId}`)
        updateHeroStatLabels()

    }

    openTradeMenu(){
        this.element.remove();
        this.tradeMenu = document.createElement("div");
        this.tradeMenu.classList.add("tradeBox");


        this.tradeMenu.innerHTML = (`
            <h5 class="text-center">${this.faceHero}</h5>
            <button onclick="this.closeTradeMenu()" id="tradeBox-close"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-x" viewBox="0 0 16 16">
            <path d="M.697 1.303a.75.75 0 0 1 1.06 0L8 6.94l6.243-6.637a.75.75 0 1 1 1.06 1.06L9.06 8l6.243 6.637a.75.75 0 1 1-1.06 1.06L8 9.06l-6.243 6.637a.75.75 0 1 1-1.06-1.06L6.94 8 .697 1.303z"/>
        </svg></button>
        <div id="backpack" class="justify-content-center">
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
        </div>
    </div>
         
        `);
        console.log(this.tradeMenu)
        document.querySelector(".game-container").appendChild(this.tradeMenu)
        this.tradeMenu.querySelector("#tradeBox-close").addEventListener("click", () => {
            this.closeTradeMenu();
        });
    }

    closeTradeMenu(){
        this.tradeMenu.remove()
        this.onComplete();
    }

    done(){
        this.element.remove();
        this.onComplete();
    }

    init(container){
        this.createElement();
        container.appendChild(this.element)
    }
}