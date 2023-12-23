class DialogMessage {
    constructor({ text, faceHero, npcId, onComplete }) {
        this.text = text;
        this.faceHero = faceHero;
        this.npcId = npcId;
        this.onComplete = onComplete;
        this.element = null;
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
                        this.done();
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
        console.log("open trade window")
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