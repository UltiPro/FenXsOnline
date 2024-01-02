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
        this.refreshedMap = null;

        //Map refresh
        this.lastRefreshTime = Date.now();
        this.refreshInterval = 1000;
        this.isRefreshed = false;

        this.monstersCache = null;
        this.itemsCache = null;
    }

    //GamLoop function
    gameLoopStepWork(delta) {
        //Clear off the canvas
        this.ctx.clearRect(0, 0, this.canvas.width, this.canvas.height);

        //Establish the camera person
        const cameraPerson = this.map.gameObjects.hero;

        //Update all objects
        Object.values(this.map.gameObjects).forEach((object) => {
            object.update({
                delta,
                arrow: this.directionInput.direction,
                map: this.map,
            });
        });

        //Draw Lower layer
        this.map.drawLowerImage(this.ctx, cameraPerson);

        // Draw items first
        Object.values(this.map.gameObjects).forEach((object) => {
            if (object instanceof Item) {
                object.sprite.draw(
                    this.ctx,
                    cameraPerson,
                    object.isBehindObject
                );
            }
        });

        // Draw the rest of gameObjects
        Object.values(this.map.gameObjects)
            .filter((object) => !(object instanceof Item))
            .sort((a, b) => {
                return a.y - b.y;
            })
            .forEach((object) => {
                object.sprite.draw(
                    this.ctx,
                    cameraPerson,
                    object.isHeroBehindObject
                );
            });

        //Draw Upper layer
        //This have to be removed
        //We use opacity system
        this.map.drawUpperImage(this.ctx, cameraPerson);
    }

    startGameLoop() {
        let previousMs;
        const step = 1 / 60;

        const stepFn = (timestampMs) => {
            if (previousMs === undefined) {
                previousMs = timestampMs;
            }

            let delta = (timestampMs - previousMs) / 1000;
            while (delta >= step) {
                this.gameLoopStepWork(delta);
                delta -= step;
            }
            previousMs = timestampMs - delta * 1000; // Unproccesed delta time
            requestAnimationFrame(stepFn);
        };

        // First tick
        requestAnimationFrame(stepFn);
    }

    //fire api call and assign to variable so it can be passed and proccessed
    async refreshMap() {
        const updatedMapData = await this.fetchRefreshedMap(); //fetching data
        this.refreshedMap = updatedMapData;
        //console.log(this.refreshedMap);
    }

    //api call
    fetchRefreshedMap() {
        return app.get(apiBaseUrl + "Map/refresh").then((response) => {
            const data = response.data;
            return data;
        });
    }

    //Run timer for map refresh
    initRefresh() {
        setInterval(() => {
            this.checkForRefresh();
        }, this.refreshInterval);
    }

    //check if time elapsed
    async checkForRefresh() {
        const currentTime = Date.now();
        const elapsedTimeSinceLastRefresh = currentTime - this.lastRefreshTime;

        if (elapsedTimeSinceLastRefresh >= this.refreshInterval) {
            await this.refreshMap();
            this.lastRefreshTime = currentTime; // Update the last refresh time
            console.log("Refreshed");
        }
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

    newMapCoords(mapConfig, eventX, eventY) {
        this.heroData.x = eventX;
        this.heroData.y = eventY;
    }

    //creating player object
    placeHero() {
        let hero = "hero";
        let placeHero = new Person({
            isPlayerControlled: true,
            x: utils.withGrid(this.heroData.x),
            y: utils.withGrid(this.heroData.y),
            src: `${getHeroSpritePath(this.heroData.profession)}/${
                this.heroData.spriteURL
            }`,
        });
        this.map.gameObjects[hero] = placeHero;
    }

    //creating npc objects
    placeNPC() {
        this.mapData.npCs.forEach((npcData) => {
            let name = npcData.name;
            let npc = name;
            let texts = [];
            let placeNPC = new Person({
                isPlayerControlled: false,
                x: utils.withGrid(npcData.x),
                y: utils.withGrid(npcData.y),
                src: `./assets/npcs/${npcData.spriteURL}`,
                behaviorLoop: [
                    { type: "stand", direction: "down", time: "200" },
                ],
                pricePercent: npcData.pricePercent,
            });
            //Check for healer/trader
            if (npcData.isHealer) {
                placeNPC.isHealerNPC = true;
                texts.push({ text: "I need healing", flag: "heal" });
            }
            if (npcData.isTrader) {
                placeNPC.isTraderNPC = true;
                texts.push({
                    text: "Show goods You're selling",
                    flag: "trade",
                });
            }
            placeNPC.talking = [
                {
                    events: [
                        {
                            type: "dialogBox",
                            text: texts,
                            faceHero: `${name}`,
                            npcId: npcData.id,
                            percent: npcData.pricePercent,
                            shopItems: npcData.shopItems,
                        },
                    ],
                },
            ];
            this.map.gameObjects[npc] = placeNPC;
        });
    }

    //creating item objects
    placeItems() {
        //console.log(this.mapData.items);
        let counter = 1;
        this.mapData.items.forEach((item) => {
            let name = "item" + counter;
            let itemId = name;
            const itemDetails = this.itemsCache[`${item.itemType}_${item.itemId}`];
            const path = itemTypeParser(itemDetails.itemType)
            let placeItem = new Item({
                isPlayerControlled: false,
                x: utils.withGrid(item.x),
                y: utils.withGrid(item.y),
                itemId: item.itemId,
                itemType: item.itemType,
                //change sprite
                src: `${path}${itemDetails.spriteURL}`,
            });
            this.map.gameObjects[itemId] = placeItem;
            counter++;
        });
    }

    //creating monsters objects
    placeMonsters() {
        let counter = 1;
        this.mapData.mobs.forEach((mob) => {
            let name = "mob" + counter;
            let objName = name;
            const monsterDetails = this.monstersCache[mob.mobId];
            let placeMob = new Monster({
                x: utils.withGrid(mob.x),
                y: utils.withGrid(mob.y),
                mobId: mob.mobId,
                src: `./assets/mobs/${monsterDetails.spriteUrl}`,
                talking: [
                    {
                        events: [
                            {
                                type: "fight",
                                x: mob.x,
                                y: mob.y,
                                mobName: monsterDetails.name,
                                who: objName,
                            },
                        ],
                    },
                ],
            });
            this.map.gameObjects[objName] = placeMob;
            counter++;
        });
    }

    async cacheMonsterDetails() {
        if (!this.monstersCache) {
            this.monstersCache = {};
        }
    
        const monsterPromises = this.mapData.mobs.map(mob => {
            const mobId = mob.mobId;
    
            if (!this.monstersCache[mobId]) {
                return this.getMonsterDetails(mobId)
                    .then(monsterDetails => {
                        this.monstersCache[mobId] = monsterDetails;
                    })
                    .catch(error => {
                        console.error('Error fetching monster details:', error);
                    });
            } else {
                return Promise.resolve(); // Resolve with an empty promise for already cached monsters
            }
        });
    
        // Wait for all promises to resolve before continuing
        await Promise.all(monsterPromises);
    }
    
    async getMonsterDetails(mobId) {
        try {
            const response = await app.get(apiBaseUrl + `Mob?id=${mobId}`);
            const monsterDetails = response.data;
            return monsterDetails;
        } catch (error) {
            console.error('Error fetching monster details:', error);
            return null;
        }
    }
    

    async cacheItemsDetails() {
        if (!this.itemsCache) {
            this.itemsCache = {};
        }
    
        const itemPromises = this.mapData.items.map(item => {
            const compositeKey = `${item.itemType}_${item.itemId}`;
    
            if (!this.itemsCache[compositeKey]) {
                return this.getItemDetails(item.itemType, item.itemId)
                    .then(itemDetails => {
                        this.itemsCache[compositeKey] = itemDetails;
                    })
                    .catch(error => {
                        console.error('Error fetching item details:', error);
                    });
            } else {
                return Promise.resolve(); // Resolve with an empty promise for already cached items
            }
        });
    
        // Wait for all promises to resolve before continuing
        await Promise.all(itemPromises);
    }
    
    
    getItemDetails(itemType, itemId) {
        return new Promise((resolve, reject) => {
            app.get(apiBaseUrl + `Item?itemType=${itemType}&id=${itemId}`)
                .then(response => {
                    const details = response.data;
                    resolve(details); // Resolve the promise with the fetched details
                })
                .catch(error => {
                    console.error('Error fetching item details:', error);
                    reject(error); // Reject the promise if there's an error
                });
        });
    }
    
    

    //Action key listner
    bindActionInput() {
        new KeyPressListner("Enter", () => {
            //Check if there's a person to talk to
            this.map.checkForAction();
        });
    }

    //area events
    bindHeroPositionCheck() {
        document.addEventListener("PersonWalkingComplete", (e) => {
            if (e.detail.whoId === "hero") {
                //Hero position has change
                //Check for events
                this.map.checkForFootstepCutscene();
            }
        });
    }

    //loading new map
    async startMap(mapConfig) {
        this.map = new OverworldMap(mapConfig); //loading current map
        this.placeHero();
        this.mapData = await this.getMapData(); //fetching heroes, npc, items
        console.log(this.mapData);
        this.placeNPC();
        await this.cacheMonsterDetails(); // Fetch and cache monsters
        await this.cacheItemsDetails(); // Fetch and cache items
        console.log(this.itemsCache)
        this.placeItems()
        this.placeMonsters();
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

        const mapConfig =
            this.heroData && mapIds[this.heroData.mapId]
                ? mapIds[this.heroData.mapId]
                : window.OverworldMaps.DefaultMap;

        this.startMap(mapConfig);
    }

    // Add a method to add and mount a gameObject
    addAndMountGameObject(gameObject) {
        this.map.addGameObject(gameObject);
        gameObject.mount(this.map);
    }

    //initializing game
    //async to fetch the data with getHero(), otherwise this.heroData will be null
    async init() {
        this.heroData = await this.getHeroData();
        console.log(this.heroData);

        this.LoadMap();

        this.bindActionInput(); //check for events by pressing button
        this.bindHeroPositionCheck(); //check for events by standing in specific area

        this.directionInput = new DirectionInput(); //directionInput object constructor
        this.directionInput.init(); //running movement function

        this.startGameLoop();
        this.initRefresh(); //starting timer for refreshMap

        this.map.startCutscene([
            //{type: "textMessage", text: "Samouczek dla gracza"}
        ]);
    }
}
