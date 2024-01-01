class OverworldEvent {
    constructor({ map, event }) {
        this.map = map;
        this.event = event;
    }

    stand(resolve) {
        const who = this.map.gameObjects[this.event.who];
        who.startBehavior(
            {
                map: this.map,
            },
            {
                type: "stand",
                direction: this.event.direction,
                time: this.event.time,
            }
        );

        //Set up a handler to complete when correct person is done walking, then resolve the event
        const completeHandler = (e) => {
            if (e.detail.whoId === this.event.who) {
                document.removeEventListener("PersonStandComplete", completeHandler);
                resolve();
            }
        };
        document.addEventListener("PersonStandComplete", completeHandler);
    }

    walk(resolve) {
        const who = this.map.gameObjects[this.event.who];
        who.startBehavior(
            {
                map: this.map,
            },
            {
                type: "walk",
                direction: this.event.direction,
                retry: true,
            }
        );

        //Set up a handler to complete when correct person is done walking
        //then resolve the event
        const completeHandler = (e) => {
            if (e.detail.whoId === this.event.who) {
                document.removeEventListener("PersonWalkingComplete", completeHandler);
                resolve();
            }   
        };
        document.addEventListener("PersonWalkingComplete", completeHandler);
    }

    textMessage(resolve) {
        //during talking with npc change npc standing direction to face character position
        if (this.event.faceHero) {
            const obj = this.map.gameObjects[this.event.faceHero];
            obj.direction = utils.oppositeDirection(this.map.gameObjects["hero"].direction);
        }

        const message = new TextMessage({
            text: this.event.text,
            onComplete: () => resolve(),
        });
        message.init(document.querySelector(".game-container"));
    }

    dialogBox(resolve) {
        //during talking with npc change npc standing direction to face character position
        if (this.event.faceHero) {
            const obj = this.map.gameObjects[this.event.faceHero];
            obj.direction = utils.oppositeDirection(this.map.gameObjects["hero"].direction);
        }
        const dialog = new DialogMessage({
            text: this.event.text,
            faceHero: this.event.faceHero,
            npcId: this.event.npcId,
            percent: this.event.percent,
            shopItems: this.event.shopItems,
            onComplete: () => resolve(),
        });
        dialog.init(document.querySelector(".game-container"));
    }

    fight(resolve){
        const obj = this.map.gameObjects[this.event.who]; //contains gameObject id, which monster should be removed
        const battle = new Battle({
            x: this.event.x,
            y: this.event.y,
            mobName: this.event.mobName,
            who: obj,
            onComplete: (isHeroDead) => {
                if (isHeroDead === null) {
                     //Player won the battle
                    console.log("You won!", isHeroDead)
                    resolve();
                } else {
                    // Player lost the battle
                    //this.handleHeroLoss();
                    console.log("You lost...", isHeroDead)
                    resolve();
                }
            },
        });
        battle.init(document.querySelector(".game-container"))

    }

    changeMap(resolve) {
        const sceneTransition = new SceneTransition();
        sceneTransition.init(document.querySelector(".game-container"), () => {
            this.map.overworld.newMapCoords(window.OverworldMaps[this.event.map],this.event.x,this.event.y);
            console.log(this.event.x, this.event.y)
            this.map.overworld.startMap(window.OverworldMaps[this.event.map]);
            resolve();

            sceneTransition.fadeOut();
        });
    }

    init() {
        return new Promise((resolve) => {
            this[this.event.type](resolve);
        });
    }

    async handleHeroLoss() {
        console.log("You died...")
    }

}
