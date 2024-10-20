class Person extends GameObject { //I wanna make sure that only player is moving, not other objects
	constructor(config) {
		super(config)
		this.movementProgressRemaining = 0;
		this.movementSpeed = 2;
		this.isStanding = false;
		this.removalKey = "heroes"
		this.isHeroBehindObject = false;
		this.isPlayerControlled = config.isPlayerControlled || false; //making sure disired player moves

		this.directionUpdate = {
			"up": ["y", -1],
			"down": ["y", 1],
			"left": ["x", -1],
			"right": ["x", 1],
		}

		this.pricePercent = this.pricePercent || 1;
		this.isHealerNPC = false;
		this.isTraderNPC = false;
		this.isDead = config.isDead || false;
	}

	update(state) {
		if (this.movementProgressRemaining > 0) {
			this.updatePosition();
		}
		else {
			//More cases 
			//Case: no event, player can provide an input and have an arrow pressed
			if (!state.map.isCutscenePlaying && this.isPlayerControlled && state.arrow) {
				this.startBehavior(state, {
					type: "walk",
					direction: state.arrow
				})
			}
			this.updateSprite(state);
			this.handleOpacityChange(state);
		}
	}

	//chaging sprite opacity when hero is behind an object
	handleOpacityChange(state) {
		//reading coords with zindex field
		const isHeroOnZIndexField = state.map.zindex[`${this.x},${this.y}`] || false;

		if (isHeroOnZIndexField !== this.isHeroBehindObject) {
			this.isHeroBehindObject = isHeroOnZIndexField;
			this.sprite.isHeroBehindObject = isHeroOnZIndexField; // Update sprite opacity
		}
	}


	startBehavior(state, behavior) {
		//Set character direction to whatever behavior has
		this.direction = behavior.direction;
		if (behavior.type === "walk") {
			//stop if the spece is not free
			if (state.map.isSpaceTaken(this.x, this.y, this.direction)) {

				behavior.retry && setTimeout(() => {
					this.startBehavior(state, behavior);
				}, 10) //if there's determined rutine, retry

				return;
			} //so...check if the player is one the collision grid
			//if it is walking progress won't be set so the walking methods won't run

			//if it's free - walk!
			state.map.checkForNpc()
			state.map.moveWall(this.x, this.y, this.direction);//moving hero collision to the place where he walks
			this.movementProgressRemaining = 32; //restarting pixel movement counter
			this.updateSprite(state);
		}
		if (behavior.type === "stand") {
			this.isStanding = true;
			setTimeout(() => {
				utils.emitEvent("PersonStandComplete", {
					whoId: this.id
				})
				this.isStanding = false;
			}, behavior.time)
		}
	}

	updatePosition() {
		const [property, change] = this.directionUpdate[this.direction];
		this[property] += change * this.movementSpeed;
		this.movementProgressRemaining -= this.movementSpeed;
		if (this.movementProgressRemaining === 0) {
			//Walk finished
			const direction = this.directionUpdate[this.direction];
			const [axis, value] = direction;
			this.movement(axis, value);

			utils.emitEvent("PersonWalkingComplete", {
				whoId: this.id
			})
		}
	}

	movement(axis, value) {
		//console.log("You moved!",axis, value)
		app.put(apiBaseUrl + `Movement?${axis}=${value}`)
	}

	//updating character sprite
	updateSprite() {
		if (this.movementProgressRemaining > 0) {
			//if any remaining movement left it mean that character is moving so...
			//directional moving animation have to be played
			this.sprite.setAnimation("walk-" + this.direction);
			return;
		}
		this.sprite.setAnimation("idle-" + this.direction);
	}
}