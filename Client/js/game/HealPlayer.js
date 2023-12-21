class HealPlayer {
    constructor({ text, onComplete }) {
        this.text = text;
        this.onComplete = onComplete;
        this.element = null;
        // this.buttons = [];
        // this.currentButtonIndex = 0;
    }

    createElement() {
        this.element = document.createElement("div");
        this.element.classList.add("TextMessage");

        this.element.innerHTML = (`
            <h4 class="TextMessage-p">${this.text}</h4>
            <p class="TextMessage-p">Welcome traveler! I'm the medic of the Fenxs city, do You need my help?</p>
            <button id="heal" class="TextMessage-button">1. I need healing!</button><br />
            <button id="close" class="TextMessage-button">2. I gotta go</button>
        `);

        this.actionListner = new KeyPressListner("Enter", () => {
            console.log("healed")
            this.actionListner.unbind();
            this.actionListner2.unbind();
            this.done();
        })

        this.actionListner2 = new KeyPressListner("Escape", () => {
            console.log("cancel")
            this.actionListner.unbind();
            this.actionListner2.unbind();
            this.done();
        })
        // this.buttons = this.element.querySelectorAll(".TextMessage-button");

        // document.addEventListener("keydown", (event) => {
        //     this.handleArrowKeyPress(event);
        // });

        // this.buttons.forEach((button, index) => {
        //     button.addEventListener("click", () => {
        //         console.log(index)
        //         this.done();
        //     });
        // });

        // this.buttons[this.currentButtonIndex].focus();

       
    } 
    // //listing for arrow choice
    // handleArrowKeyPress(event) {
    //     if (event.key === "ArrowDown" || event.key === "ArrowRight") {
    //         event.preventDefault();
    //         this.currentButtonIndex = (this.currentButtonIndex + 1) % this.buttons.length;
    //         this.buttons[this.currentButtonIndex].focus();
    //     } else if (event.key === "ArrowUp" || event.key === "ArrowLeft") {
    //         event.preventDefault();
    //         this.currentButtonIndex = (this.currentButtonIndex - 1 + this.buttons.length) % this.buttons.length;
    //         this.buttons[this.currentButtonIndex].focus();
    //     }
    // }

    

    done(){
        this.element.remove();
        this.onComplete();
    }

    init(container){
        this.createElement();
        container.appendChild(this.element)
    }
}