class OverworldMap {
    constructor(config) {
        this.overworld = null;
        this.gameObjects = config.gameObjects || {};
        this.walls = config.walls || {};
        this.zindex = config.zindex || {};
        this.cutsceneSpaces = config.cutsceneSpaces || {};

        //lower layer of the map, gameobjects should be visible
        this.lowerImage = new Image();
        this.lowerImage.src = config.lowerSrc;

        //upper layer of the map like trees etc, gameobjects should not be visible
        this.upperImage = new Image();
        this.upperImage.src = config.upperSrc;

        this.isCutscenePlaying = false;

        this.displayedNPC = null;
        this.talkButtonRef = null;
    }

    //drawing lower layer of the map
    //drawing context and aplaying person position to adjust the camera
    drawLowerImage(ctx, cameraPerson) {
        ctx.drawImage(this.lowerImage, utils.withGrid(14) - cameraPerson.x, utils.withGrid(10) - cameraPerson.y);
    }

    //drawing upper layer of the map
    drawUpperImage(ctx, cameraPerson) {
        ctx.drawImage(this.upperImage, utils.withGrid(14) - cameraPerson.x, utils.withGrid(10) - cameraPerson.y);
    }
    //check if hero can walk to the position
    isSpaceTaken(currentX, currentY, direction) {
        const { x, y } = utils.nextPosition(currentX, currentY, direction);
        return this.walls[`${x},${y}`] || false;
    }

    //checking if hero is behind an object
    isHeroBehindObject(currentX, currentY, direction) {
        const { x, y } = utils.nextPosition(currentX, currentY, direction);
        return this.zindex[`${x},${y}`] || false;
    }

    mountObjects() {
        Object.keys(this.gameObjects).forEach((key) => {
            let object = this.gameObjects[key];
            object.id = key;
            object.mount(this);
        });
    }

    async startCutscene(events) {
        this.isCutscenePlaying = true;
        //start a loop of async events
        //await each one
        for (let i = 0; i < events.length; i++) {
            const event = new OverworldEvent({
                event: events[i],
                map: this,
            });
            await event.init();
        }

        this.isCutscenePlaying = false;

        //Reset NPC to do idle behavior
        Object.values(this.gameObjects).forEach((object) => object.doBehaviorEvent(this));
    }

    //check for event for ex. talking
    checkForAction() {
        const hero = this.gameObjects["hero"]; //current player
        const nextCoords = utils.nextPosition(hero.x, hero.y, hero.direction); //npc
        const match = Object.values(this.gameObjects).find((object) => {
            return `${object.x}, ${object.y}` === `${nextCoords.x}, ${nextCoords.y}`;
        });
        if (!this.isCutscenePlaying && match && match.talking.length) {
            this.removeTalkButton()
            this.displayedNPC = null;
            this.startCutscene(match.talking[0].events);
        }
        // console.log(match);
    }

    //check if npc is nearby
    checkForNpc() {
        const hero = this.gameObjects["hero"];
        const nextCoords = utils.nextPosition(hero.x, hero.y, hero.direction);
    
        const nearbyObject = Object.values(this.gameObjects).find((object) => {
            if (object.id !== "hero") {
                const distance = Math.sqrt(Math.pow(object.x - nextCoords.x, 2) + Math.pow(object.y - nextCoords.y, 2));
                if (distance <= 32) {
                    console.log(`Hero position: (${hero.x}, ${hero.y})`);
                    console.log(`NPC position: (${object.x}, ${object.y})`);
                    return true; // Object is within the specified distance
                }
            }
            return false;
        });
    
        // Check if it's an NPC
        if (!this.isCutscenePlaying && nearbyObject && nearbyObject.talking && nearbyObject.talking.length > 0) {
            if (this.displayedNPC !== nearbyObject.id) {
                const approachDirection = this.calculateApproachDirection(hero, nearbyObject);
                this.displayedNPC = nearbyObject.id;
                this.displayTalkButton(nearbyObject, approachDirection); // Show talk button
            }
        } else {
            if (this.talkButtonRef) {
                // Remove after walking away
                this.removeTalkButton();
                this.displayedNPC = null;
            }
        }
    }
    
    calculateApproachDirection(hero, npc) {
        const deltaX = npc.x - hero.x;
        const deltaY = npc.y - hero.y;
    
        // Determine the direction based on relative positions
        if (Math.abs(deltaX) > Math.abs(deltaY)) {
            return deltaX > 0 ? "right" : "left";
        } else {
            return deltaY > 0 ? "down" : "up";
        }
    }

    // Function to display the talk button
    displayTalkButton(match, approachDirection) {
        if (match && match.talking && match.talking.length > 0) {
            const talkButton = document.createElement("button");
            talkButton.innerHTML = "Talk";
            talkButton.classList.add("talk-button");
            const windowWidth = window.innerWidth;
            const windowHeight = window.innerHeight;
            talkButton.style.left = `${windowWidth / 2 - 70}px`;
            talkButton.style.top = `${windowHeight / 2}px`;

            talkButton.onclick = () => {
            
                this.startCutscene(match.talking[0].events);
                this.removeTalkButton(); // Remove button after click
                this.displayedNPC = null;
            };

            document.body.appendChild(talkButton);
            this.talkButtonRef = talkButton; // Store a reference to the talk button
        }
    }

    // Function to remove the talk button
    removeTalkButton() {
        if (this.talkButtonRef) {
            this.talkButtonRef.remove();
            this.talkButtonRef = null;
        }
    }

    //check for event by entering specific area
    checkForFootstepCutscene() {
        const hero = this.gameObjects["hero"]; //current player
        const match = this.cutsceneSpaces[`${hero.x},${hero.y}`];
        if (!this.isCutscenePlaying && match) {
            this.startCutscene(match[0].events);
        }
        // console.log(match);
    }

    addWall(x, y) {
        this.walls[`${x},${y}`] = true;
    }

    removeWall(x, y) {
        delete this.walls[`${x},${y}`];
    }

    moveWall(OldX, OldY, direction) {
        this.removeWall(OldX, OldY); //removing wall
        const { x, y } = utils.nextPosition(OldX, OldY, direction); //offset of direction, getting new position of the wall
        this.addWall(x, y); //creating the new wall
    }
}
//maps configuration
window.OverworldMaps = {
    Home: {
        id: "Home",
        lowerSrc: "./assets/maps/home.png",
        upperSrc: "",
        gameObjects: {
            // npc1: new Person({
            //     isPlayerControlled: false, //npc shouldn't walk and they're in person class so I added a flag in the Person class
            //     x: utils.withGrid(10),
            //     y: utils.withGrid(3),
            //     src: "./assets/heroes/mage/mageM20.gif",
            //     behaviorLoop: [{ type: "stand", direction: "up", time: "200" }],
            //     talking: [
            //         {
            //             events: [{ type: "textMessage", text: "Why hello there, Old Sport!", faceHero: "npc1" }],
            //         },
            //     ],
            // }),
        },
        //walls contains cells where collision are
        walls: {
            // [] surrounding asGridCoords for dynamic key
            // row 0
            [utils.asGridCoord(0, 0)]: true,
            [utils.asGridCoord(1, 0)]: true,
            [utils.asGridCoord(2, 0)]: true,
            [utils.asGridCoord(3, 0)]: true,
            [utils.asGridCoord(4, 0)]: true,
            [utils.asGridCoord(5, 0)]: true,
            [utils.asGridCoord(6, 0)]: true,
            [utils.asGridCoord(7, 0)]: true,
            [utils.asGridCoord(8, 0)]: true,
            [utils.asGridCoord(9, 0)]: true,
            [utils.asGridCoord(10, 0)]: true,
            [utils.asGridCoord(11, 0)]: true,
            [utils.asGridCoord(12, 0)]: true,
            //row 1
            [utils.asGridCoord(0, 1)]: true,
            [utils.asGridCoord(1, 1)]: true,
            [utils.asGridCoord(2, 1)]: true,
            [utils.asGridCoord(3, 1)]: true,
            [utils.asGridCoord(4, 1)]: true,
            [utils.asGridCoord(5, 1)]: true,
            [utils.asGridCoord(6, 1)]: true,
            [utils.asGridCoord(7, 1)]: true,
            [utils.asGridCoord(8, 1)]: true,
            [utils.asGridCoord(9, 1)]: true,
            [utils.asGridCoord(10, 1)]: true,
            [utils.asGridCoord(11, 1)]: true,
            [utils.asGridCoord(12, 1)]: true,
            // row 2
            [utils.asGridCoord(0, 2)]: true,
            [utils.asGridCoord(1, 2)]: true,
            [utils.asGridCoord(2, 2)]: true,
            [utils.asGridCoord(3, 2)]: true,
            [utils.asGridCoord(4, 2)]: true,
            [utils.asGridCoord(5, 2)]: true,
            [utils.asGridCoord(6, 2)]: true,
            [utils.asGridCoord(7, 2)]: true,
            [utils.asGridCoord(8, 2)]: true,
            [utils.asGridCoord(9, 2)]: true,
            [utils.asGridCoord(10, 2)]: true,
            [utils.asGridCoord(11, 2)]: true,
            [utils.asGridCoord(12, 2)]: true,
            // row 3
            [utils.asGridCoord(0, 3)]: true,
            [utils.asGridCoord(1, 3)]: true,
            [utils.asGridCoord(5, 3)]: true,
            [utils.asGridCoord(12, 3)]: true,
            // row 4
            [utils.asGridCoord(0, 4)]: true,
            [utils.asGridCoord(5, 4)]: true,
            [utils.asGridCoord(8, 4)]: true,
            [utils.asGridCoord(9, 4)]: true,
            [utils.asGridCoord(10, 4)]: true,
            [utils.asGridCoord(11, 4)]: true,
            [utils.asGridCoord(12, 4)]: true,
            // row 5
            [utils.asGridCoord(0, 5)]: true,
            [utils.asGridCoord(4, 5)]: false,
            [utils.asGridCoord(5, 5)]: true,
            [utils.asGridCoord(8, 5)]: true,
            [utils.asGridCoord(9, 5)]: true,
            [utils.asGridCoord(10, 5)]: true,
            [utils.asGridCoord(11, 5)]: true,
            [utils.asGridCoord(12, 5)]: true,
            // row 6
            [utils.asGridCoord(0, 6)]: true,
            [utils.asGridCoord(1, 6)]: true,
            [utils.asGridCoord(4, 6)]: true,
            [utils.asGridCoord(5, 6)]: true,
            [utils.asGridCoord(9, 6)]: true,
            [utils.asGridCoord(10, 6)]: true,
            [utils.asGridCoord(11, 6)]: true,
            [utils.asGridCoord(12, 6)]: true,
            // row 7
            [utils.asGridCoord(0, 7)]: true,
            [utils.asGridCoord(1, 7)]: true,
            [utils.asGridCoord(12, 7)]: true,
            // row 8
            [utils.asGridCoord(0, 8)]: true,
            [utils.asGridCoord(1, 8)]: true,
            [utils.asGridCoord(12, 8)]: true,
            // row 9
            [utils.asGridCoord(0, 9)]: true,
            [utils.asGridCoord(1, 9)]: true,
            [utils.asGridCoord(2, 9)]: true,
            [utils.asGridCoord(3, 9)]: true,
            [utils.asGridCoord(4, 9)]: true,
            [utils.asGridCoord(5, 9)]: true,
            [utils.asGridCoord(6, 9)]: true,
            [utils.asGridCoord(9, 9)]: true,
            [utils.asGridCoord(10, 9)]: true,
            [utils.asGridCoord(11, 9)]: true,
            [utils.asGridCoord(12, 9)]: true,
            // row 10
            [utils.asGridCoord(0, 10)]: true,
            [utils.asGridCoord(1, 10)]: true,
            [utils.asGridCoord(2, 10)]: true,
            [utils.asGridCoord(3, 10)]: true,
            [utils.asGridCoord(4, 10)]: true,
            [utils.asGridCoord(5, 10)]: true,
            [utils.asGridCoord(6, 10)]: true,
            [utils.asGridCoord(7, 10)]: true,
            [utils.asGridCoord(8, 10)]: true,
            [utils.asGridCoord(9, 10)]: true,
            [utils.asGridCoord(10, 10)]: true,
            [utils.asGridCoord(11, 10)]: true,
            [utils.asGridCoord(12, 10)]: true,
        },
        zindex: {
            [utils.asGridCoord(4, 5)]: true,
        },
        cutsceneSpaces: {
            [utils.asGridCoord(4, 5)]: [
                {
                    events: [{ type: "textMessage", text: "What a beautiful lil tree!" }],
                },
            ],
            [utils.asGridCoord(8, 9)]: [
                {
                    events: [{ type: "changeMap", map: "City" }],
                },
            ],
            [utils.asGridCoord(7, 9)]: [
                {
                    events: [{ type: "changeMap", map: "City" }],
                },
            ],
        },
    },

    City: {
        id: "City",
        lowerSrc: "./assets/maps/fenxscity.png",
        upperSrc: "",
        gameObjects: {},
        cutsceneSpaces: {
            [utils.asGridCoord(6, 79)]: [
                {
                    events: [{ type: "changeMap", map: "Home" }],
                },
            ],
        },
    },

    Cave: {
        id: "Cave",
        lowerSrc: "./assets/maps/nearcave.png",
        upperSrc: "",
        gameObjects: {},
    },

    Ruins: {
        id: "Ruins",
        lowerSrc: "./assets/maps/ruins.png",
    },
};
