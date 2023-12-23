class Sprite{
	constructor(config){
		
		//Set up the image
		this.image = new Image();
		this.image.src = config.src;
		this.image.onload = () => {
			this.isLoaded = true;
		}
		//Animation & Initial State
		//In the future more animations and there behaviour can be programmed
		//based just on the coords in the arrays here
		//animation playing system should probably stay untouched
		this.animations = config.animations || {
			"idle-down": [ [0,0] ],
			"walk-down": [ [1,0], [2,0] ,[3,0] , [2,0] ],
			"idle-left": [ [0,1] ],
			"walk-left": [ [1,1], [2,1] , [3,1], [2,1] ],
			"idle-right": [ [0,2] ],
			"walk-right": [ [1,2], [2,2], [3,2], [2,2] ],
			"idle-up": [ [0,3] ],
			"walk-up": [ [1,3], [2,3] , [3,3], [2,3] ],
		}
		
		this.currentAnimation = config.currentAnimation || "idle-down";
		this.currentAnimationFrame = 0;
		
		//animation
		this.animationFrameLimit = config.animationFrameLimit || 32; //how many gameloop frames to show an animation
		this.animationFrameProgress = this.animationFrameLimit; //time to switch animation frame


		//Reference the game Object
		this.gameObject = config.gameObject;
	}
	
	get frame(){
		return this.animations[this.currentAnimation][this.currentAnimationFrame]
	}

	//changing animation method
	setAnimation(key){
		if(this.currentAnimation !== key){
			this.currentAnimation = key;
			this.currentAnimationFrame = 0; //reseting frame back to 0
			this.animationFrameProgress = this.animationFrameLimit; //counter checking when to switch the frame also gets a reset
		}
	}

	updateAnimationProgress() {
		// Downtick frame progress
		if (this.animationFrameProgress > 0) {
			this.animationFrameProgress -= 1;
			return;
		}
	
		// Reset the counter
		this.animationFrameProgress = this.animationFrameLimit;
		this.currentAnimationFrame += 1;
	
		if (this.frame === undefined) {
			this.currentAnimationFrame = 0;
		}
	}



	draw(ctx, cameraPerson, isBehindObject){
		const x = this.gameObject.x - 0 + utils.withGrid(14) - cameraPerson.x; // x and y -> current object position
		const y = this.gameObject.y - 15 + utils.withGrid(10) - cameraPerson.y; // x/y - smth -> smth is the pixel correction for placement 
		// + utils - cameraPerson -> taking gridbased movement and subtracting cameraObject placement
		//7-> 14 grid tiles / 2 ; 5 -> 10 tiles / 2
		//when canvas dimentions are changed those values have to be changed too based on this math
		
		const[frameX, frameY] = this.frame; //getting appropriate frame to cute from spritesheet
		
		//chaging hero opacity behind object
		if (isBehindObject) {
			ctx.globalAlpha = 0.3;
			// ctx.fillStyle = 'black';
			// ctx.fillRect(x, y + 32, 32, 32); 
		}
		
		this.isLoaded && ctx.drawImage(this.image,
		frameX * 32, frameY * 48,
		32,48,
		x,y,
		32,48
		)
		ctx.globalAlpha = 1;
		this.updateAnimationProgress();
	}

	
}