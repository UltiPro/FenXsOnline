class Item extends GameObject {
    constructor(config) {
        super(config);
        this.isItem = true;
        this.isBehindObject = false;
        this.itemId = config.itemId;
        this.itemType = config.itemType;
    }

    update(state) {
        this.updateSprite(state);
        this.handleOpacityChange(state);
    }

    updateSprite() {
        this.sprite.setAnimation("idle-" + this.direction);
    }

    mount() {
        this.isMounted = true;
    }

    //chaging sprite opacity when hero is behind an object
    handleOpacityChange(state) {
        //reading coords with zindex field
        const isBehindObject =
            state.map.zindex[`${this.x},${this.y}`] || false;

        if (isBehindObject !== this.isBehindObject) {
            this.isBehindObject = isBehindObject;
            this.sprite.isBehindObject = isBehindObject; // Update sprite opacity
        }
    }

    async grab(item) {
        try {
            await app.put(apiBaseUrl + "Map/grab");
            console.log("Item has been picked up");
            showGrabbedItem(item);
            return true;
        } catch (error) {
            console.error("Failed to pick up item:", error);
            return false;
        }
    }
}
