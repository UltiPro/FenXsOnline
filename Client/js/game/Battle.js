class Battle{
    constructor({ x,y, mobName, who ,onComplete }) {
        this.x = x;
        this.y = y;
        this.name = mobName;
        this.who = who;
        this.onComplete = onComplete;
        this.text = [];
        this.dead = null;
        this.drop = null;
       
    }

    createElement() {
        this.element = document.createElement("div");
        this.element.classList.add("battle");

        this.element.innerHTML = `
            <h4 class="TextMessage-p">Fighting: ${this.name}</h4>
            <ul class="TextMessage-p" id="logList">
                <!-- This is where the logs will be appended -->
            </ul>
            <button id="battle-close"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-x" viewBox="0 0 16 16">
            <path d="M.697 1.303a.75.75 0 0 1 1.06 0L8 6.94l6.243-6.637a.75.75 0 1 1 1.06 1.06L9.06 8l6.243 6.637a.75.75 0 1 1-1.06 1.06L8 9.06l-6.243 6.637a.75.75 0 1 1-1.06-1.06L6.94 8 .697 1.303z"/>
        </svg></button>
        `;

        const logList = this.element.querySelector("#logList");

        this.text.forEach((log) => {
            const li = document.createElement("li");
            li.textContent = log;
            logList.appendChild(li);
        });
        

        this.element.querySelector("button").addEventListener("click", () => {
            this.done(); //Close text message
         });
         //Closing on pressing enter
         this.actionListner = new KeyPressListner("Enter", () => {
             this.actionListner.unbind();
             this.done();
         })
    }

    async fetchBattleLogs() {
        return app.put(apiBaseUrl + `Fight/mob?x=${this.x}&y=${this.y}`).then((response) =>{
            this.text = response.data.logs;
            this.dead = response.data.dead;
            this.drop = response.data.drop;
            console.log(response.data)
            return this.text
        }).catch((err) => {console.log("fetchBattleLogs error", err)})
    }

    done() {
        this.element.remove();
        $('#equipment-container').css('pointer-events', 'auto');
        this.onComplete(this.dead, this.drop);
    }

    async init(container) {
        await this.fetchBattleLogs();
        await updateHeroStatLabels()
        $('#equipment-container').css('pointer-events', 'none');
        this.createElement();
        container.appendChild(this.element);
    }
}