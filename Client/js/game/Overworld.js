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

        //Map refresh
        this.refreshedMap = null;
        this.oldMap = null;
        this.refreshDifference = null;
        this.lastRefreshTime = Date.now();
        this.refreshInterval = 200;
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
        //This have to be removed/empty image have to be used
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
        this.oldMap = this.refreshedMap ? { ...this.refreshedMap } : null;
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
            this.compareRefreshedMaps();
            this.getSpecificDifference()
        }
    }
    //comparing refreshed maps to remove/add lacking gameObjects
    async compareRefreshedMaps() {
        const differences = {};
    
        if (this.oldMap && this.refreshedMap) {
            for (const key in this.oldMap) {
                if (!_.isEqual(this.oldMap[key], this.refreshedMap[key])) {
                    differences[key] = {
                        old: this.oldMap[key],
                        new: this.refreshedMap[key]
                    };
                }
            }
        }
        this.refreshDifference = differences;
    }
    //placing/removing objects based on refreshed map data
    getSpecificDifference() {
        for (const key in this.refreshDifference) {
            console.log(`Difference in object with key '${key}':`);
    
            const oldList = this.refreshDifference[key].old;
            const newList = this.refreshDifference[key].new;
    
            // Find elements that are in newList but not in oldList
            const added = newList.filter(newItem => !oldList.some(oldItem => _.isEqual(newItem, oldItem)));
            if (added.length > 0) {
                //console.log(`Added elements:`, added);
                added.forEach(addedElem => {
                    //console.log(`Adding wall for element with key '${key}' and coordinates (${addedElem.x}, ${addedElem.y})`);
                    if (key === "items") {
                        const itemsArray = [addedElem];
                        this.placeItems(itemsArray);
                    }
                    if (key === "mobs") {
                        const mobsArray = [addedElem];
                        this.placeMonsters(mobsArray);
                        this.map.addWall(addedElem.x * 32, addedElem.y * 32);
                    }
                    if(key === "heroes"){
                        const heroesArray = [addedElem];
                        this.placeOtherPlayers(heroesArray)
                    }
                });
            }
    
            // Find elements that are in oldList but not in newList
            const removed = oldList.filter(oldItem => !newList.some(newItem => _.isEqual(newItem, oldItem)));
    
            if (removed.length > 0) {
                console.log(`Removed elements:`, removed);
                // Same coords are removed
                // Check later if the player is not staying here too
                removed.forEach(removedElem => {
                    for (const objectId in this.map.gameObjects) {
                        const obj = this.map.gameObjects[objectId];
                        if (obj.x === removedElem.x * 32 && obj.y === removedElem.y * 32 && obj.removalKey === key) {
                            //if it's monster - remove collision
                            if (obj.isMonster) {
                                this.map.removeWall(removedElem.x * 32, removedElem.y * 32);
                            }
                            if (!(obj.isOtherPlayer || obj.isPlayerControlled)) {
                                delete this.map.gameObjects[objectId];
                            }
                        }
                    }
                });
            }
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

    //fetching map data
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

    //coords change after map change/lost battle
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
                pricePercent: npcData.pricePercent,
            });
            //check for npc quest stages
            if (npcData.questsStage && npcData.questsStage.length > 0) {
                npcData.questsStage.forEach((stage) => {
                    texts.push({
                        text: stage.npcMessage, 
                        flag: `questStage`,
                    });
                });
            }
            //check for npc quest
            if (npcData.quests && npcData.quests.length > 0) {
                npcData.quests.forEach(quest => {
                    texts.push({
                        text: quest.title,
                        flag: "quest",
                    });
                });
            }
            //check for healer/trader
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
                            quests: npcData.quests,
                            questsStage: npcData.questsStage
                        },
                    ],
                },
            ];
            this.map.gameObjects[npc] = placeNPC;
        });
    }

    //creating item objects
    placeItems(items) {
        let counter = 1;
        items.forEach((item) => {
            let name = `item${counter}`;
            while (this.map.gameObjects[name]) {
                counter++;
                name = `item${counter}`;
            }
            const itemId = name;
            const itemDetails = this.itemsCache[`${item.itemType}_${item.itemId}`];
            const path = itemTypeParser(itemDetails.itemType);
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
    placeMonsters(mobs) {
        let counter = 1;
        mobs.forEach((mob) => {
            let name = `mob${counter}`;
            while (this.map.gameObjects[name]) {
                counter++;
                name = `mob${counter}`;
            }
            const objName = name;
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
    
    //placing human players
    placeOtherPlayers(heroes){
        let counter = 1;
        heroes.forEach((playerData) => {
            let name = `player${counter}`;
            while (this.map.gameObjects[name]) {
                counter++;
                name = `player${counter}`;
            }
            let objName = name;
            let placePlayer = new Person({
                isPlayerControlled: false,
                x: utils.withGrid(playerData.x),
                y: utils.withGrid(playerData.y),
                src: `${getHeroSpritePath(playerData.profession)}/${
                    playerData.spriteURL
                }`,
                isOtherPlayer: true,
            });
            this.map.gameObjects[objName] = placePlayer;
        });
    }

    //caching for monsters
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
    
    //fetch info if monster ID is absent in cache
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
    
    //caching itemDetails
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
    
    //fetching item details if it's absent in itemsCache
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
    
    async questUpdate(){
        this.mapData = await this.getMapData();
        this.placeNPC();
    }

    //Action key listner
    bindActionInput() {
        new KeyPressListner("Enter", () => {
            //Check if there's a person to talk to/monster to fight/item to grab
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
        this.placeItems(this.mapData.items)
        this.placeMonsters(this.mapData.mobs);
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
