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
            onComplete: async (deathInfo, drop) => {
                if (deathInfo === null) {
                    //Player won the battle
                    console.log("You won!", deathInfo)
                    if (drop === null) {
                        console.log("No loot :(")
                    } else {
                        console.log("Loot! :3", drop)
                        showGrabbedItem(drop); //getting loot
                    }
                    resolve();
                } else {
                    // Player lost the battle
                    //removing hero old collision
                    const heroX = this.map.gameObjects["hero"].x
                    const heroY = this.map.gameObjects["hero"].y
                    delete this.map.walls[`${heroX},${heroY}`]
                    //counting respawn time
                    await this.respawnDelay(deathInfo);
                    //teleporting player to the respawn place
                    const keys = Object.keys(window.OverworldMaps); //all map IDs
                    const respawn = keys[deathInfo.mapId]; //map to be respawned at
                    this.map.overworld.newMapCoords(window.OverworldMaps[respawn], deathInfo.x, deathInfo.y);
                    this.map.overworld.startMap(window.OverworldMaps[respawn]);
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
            console.log(this.event.map, this.event.x, this.event.y)
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

    async respawnDelay(deathInfo) {
        $('#equipment-container').css('pointer-events', 'none'); //disabling Equipment
        const blackOverlay = $('<div></div>').addClass('black-overlay');
        $('.game-container').append(blackOverlay);
        blackOverlay.css('opacity', 1);
    
        // Get the stored death time from localStorage
        const storedDeathTime = localStorage.getItem('deathTime');
        let deathTime;
    
        if (storedDeathTime) {
            deathTime = parseInt(storedDeathTime, 10);
        } else {
            // Set a new death time if not already stored
            deathTime = new Date(deathInfo.dead).getTime();
            localStorage.setItem('deathTime', deathTime);
        }
    
        const countdownElement = $('<div></div>').addClass('countdown');
        blackOverlay.append(countdownElement);
    
        const countdownInterval = setInterval(() => {
            const remainingTime = Math.ceil((deathTime - new Date().getTime()) / 1000);
            countdownElement.text(`Respawn in ${remainingTime}s`);
        }, 1000);
    
        const currentTime = new Date().getTime();
        const delay = deathTime - currentTime;
    
        await new Promise((resolve) => {
            setTimeout(() => {
                clearInterval(countdownInterval);
                blackOverlay.css('transition', 'opacity 0.5s ease-out').css('opacity', 0);
    
                setTimeout(() => {
                    blackOverlay.remove();
                    localStorage.removeItem('deathTime'); // Clear the stored death time
                    $('#equipment-container').css('pointer-events', 'auto'); //enabling equipment
                    resolve();
                }, 500);
            }, delay);
        });
    
        console.log('Time delay elapsed!');
    }
    
    async getLoot(){
        
    }
}
