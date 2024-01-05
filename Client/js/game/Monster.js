class Monster extends GameObject{
    constructor(config){
        super(config)
        this.isMonster = true;
        this.mobId = config.mobId;
        this.isDead = config.isDead || false;
        this.removalKey = "mobs"
    }

    killed(){
        this.isDead = true;
    }

    update(state) {
        this.updateSprite(state);
        this.handleOpacityChange(state);
    }

    updateSprite() {
        this.sprite.setAnimation("idle-" + this.direction);
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
}