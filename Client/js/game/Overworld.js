/* this class stores gamecanvas, all game logic have it's base here
main methods are used there, objects are placed here
the class contains gameloop definition

init.js use init() method that is definded and modified right here*/

class Overworld {
    constructor(config) {
        this.element = config.element;
        this.canvas = this.element.querySelector(".game-canvas");
        this.ctx = this.canvas.getContext("2d");
        this.map = null;
        this.heroData = null; //hero data fetched from database
        this.mapData = null;
    }

    //GamLoop function
    startGameLoop() {
        const step = () => {
            //clearing canvas at the start of the next frame
            this.ctx.clearRect(0, 0, this.canvas.width, this.canvas.height);

            //Establish the camera object
            //For now I don't now how to resolve it in multiplayer
            //how to detect individual players there?
            const cameraPerson = this.map.gameObjects.hero;
            //update all objects
            //drawing have to be done after updating objects
            //so drawing methods are below
            Object.values(this.map.gameObjects).forEach((object) => {
                object.update({
                    arrow: this.directionInput.direction,
                    map: this.map,
                });
            });

            //draw lower layer of the map
            this.map.drawLowerImage(this.ctx, cameraPerson);

            //draw "center" layer, all game objects
            Object.values(this.map.gameObjects)
                .sort((a, b) => {
                    return a.y - b.y;
                })
                .forEach((object) => {
                    object.sprite.draw(this.ctx, cameraPerson, object.isHeroBehindObject);
                });

            //draw lower layer of the map
            this.map.drawUpperImage(this.ctx, cameraPerson);

            requestAnimationFrame(() => {
                step();
            });
        };
        step();
    }

    //fetching hero data
    getHeroData() {
        return app
            .get(apiBaseUrl + "Hero")
            .then((response) => {
                const data = response.data;
                //console.log(data)
                return data;
            })
            .catch((error) => {
                console.error("Error fetching data:", error);
            });
    }

    getMapData() {
        return app
            .get(apiBaseUrl + "Map")
            .then((response) => {
                //console.log(response.data)
                return response.data;
            })
            .catch((err) => {
                console.error("Problem with fetching map data: ", err);
            });
    }

    newMapCoords(mapConfig) {
        //console.log(mapConfig)
        switch (mapConfig.id) {
            case "Home":
                this.heroData.x = 7;
                this.heroData.y = 9;
                break;
            case "City":
                this.heroData.x = 6;
                this.heroData.y = 79;
                break;
            case "Cave":
                this.heroData.x = 6;
                this.heroData.y = 79;
                break;
            case "Ruins":
                this.heroData.x = 6;
                this.heroData.y = 79;
                break;
        }
    }

    placeHero() {
        let hero = "hero";
        let placeHero = new Person({
            isPlayerControlled: true,
            x: utils.withGrid(this.heroData.x),
            y: utils.withGrid(this.heroData.y),
            src: `${getHeroSpritePath(this.heroData.profession)}/${this.heroData.spriteURL}`,
        });
        this.map.gameObjects[hero] = placeHero;
    }

    placeNPC() {
		console.log(this.mapData.npCs)
        this.mapData.npCs.forEach((npcData) => {
            let name = npcData.name; 
            let npc = name;
			let texts = [];
            let placeNPC = new Person({
                isPlayerControlled: false,
                x: utils.withGrid(npcData.x),
                y: utils.withGrid(npcData.y),
                src: `./assets/npcs/${npcData.spriteURL}`,
				behaviorLoop: [{ type: "stand", direction: "down", time: "200" }],
				pricePercent: npcData.pricePercent
            });
            //Check for healer/trader
            if (npcData.isHealer) {
                placeNPC.isHealerNPC = true;
				texts.push({ text: "I need healing", flag: "heal" });
            }
			if(npcData.isTrader){
				placeNPC.isTraderNPC = true;
				texts.push({ text: "Show goods You're selling", flag: "trade" });
			}
			placeNPC.talking = [
				{
					events: [{ type: "dialogBox",  text: texts, faceHero: `${name}`, npcId: npcData.id}],
				},
			];
            this.map.gameObjects[npc] = placeNPC;
        });
    }

    bindActionInput() {
        new KeyPressListner("Enter", () => {
            //Check if there's a person to talk to
            this.map.checkForAction();
        });
    }

    bindHeroPositionCheck() {
        document.addEventListener("PersonWalkingComplete", (e) => {
            if (e.detail.whoId === "hero") {
                //Hero position has change
                //Check for events
                this.map.checkForFootstepCutscene();
            }
        });
    }

    async startMap(mapConfig) {
        this.map = new OverworldMap(mapConfig); //loading current map
        this.placeHero();
        this.placeNPC();
        this.map.overworld = this;
        this.map.mountObjects(); //mounting objects collisions
    }

    //load map based on ID fetched from database
    LoadMap() {
        const mapIds = {
            0: window.OverworldMaps.Home,
            1: window.OverworldMaps.City,
            2: window.OverworldMaps.Cave,
            3: window.OverworldMaps.Ruin,
        };

        const mapConfig = this.heroData && mapIds[this.heroData.mapId] ? mapIds[this.heroData.mapId] : window.OverworldMaps.DefaultMap;

        this.startMap(mapConfig);
    }

    //async to fetch the data with getHero(), otherwise this.heroData will be null
    async init() {
        this.heroData = await this.getHeroData();
        this.mapData = await this.getMapData();
        console.log(this.heroData);

        this.LoadMap();
        //this.startMap(window.OverworldMaps.Cave);

        this.bindActionInput(); //check for events by pressing button
        this.bindHeroPositionCheck(); //check for events by standing in specific area

        this.directionInput = new DirectionInput(); //directionInput object constructor
        this.directionInput.init(); //running movement function

        this.startGameLoop();

        this.map.startCutscene([
            //{type: "textMessage", text: "Samouczek dla gracza"}
        ]);
    }
}
