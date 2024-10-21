class TextMessage {
    constructor({ text, onComplete }) {
        this.text = text;
        this.onComplete = onComplete;
        this.element = null;
    }

    createElement() {
        this.element = document.createElement("div");
        this.element.classList.add("TextMessage");

        this.element.innerHTML = (`
        <p class="TextMessage-p">${this.text}</p>
        <button class="TextMessage-button">End Conversation</button>
        `)

        this.element.querySelector("button").addEventListener("click", () => {
            this.done(); //Close text message
        });
        //Closing on pressing enter
        this.actionListner = new KeyPressListner("Enter", () => {
            this.actionListner.unbind();
            this.done();
        })
    }

    done() {
        this.element.remove();
        this.onComplete();
    }

    init(container) {
        this.createElement();
        container.appendChild(this.element)
    }
}