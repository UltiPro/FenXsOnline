class GameObject{
	constructor(config){
		this.id = null;
		this.isMounted = false;
		this.x = config.x || 0;
		this.y = config.y || 0;
		this.direction = config.direction || "down";
		this.sprite = new Sprite({
			gameObject: this,
			src: config.src || "./assets/heroes/hunter/hunterF0.gif",
		});
		
		this.behaviorLoop = config.behaviorLoop || [];
		this.behaviorLoopIndex = 0;

		//if obeject is an npc it will have talking events queue
		this.talking = config.talking || [];
	}
	

	mount(map){
		this.isMounted = true;
		map.addWall(this.x, this.y);

		//if there's behavior run
		setTimeout(() => {
			this.doBehaviorEvent(map);
		}, 10)
	}
	//updating objects for ex. when they move
	update(){
		
		
	}

	async doBehaviorEvent(map){
		//if there's something more important going on break
		if(map.isCutscenePlaying || this.behaviorLoop.length === 0 || this.isStanding){
			return;
		} 
		//Setting up eventt with relevant info
		let eventConfig = this.behaviorLoop[this.behaviorLoopIndex];
		eventConfig.who = this.id;

		//Event handler for changing map, music etc
		//Create an event instance out of next event config
		const eventHandler = new OverworldEvent({map, event: eventConfig});
		await eventHandler.init();

		//Setting the next event
		this.behaviorLoopIndex += 1;
		if(this.behaviorLoopIndex === this.behaviorLoop.length){
			this.behaviorLoopIndex = 0;
		}

		this.doBehaviorEvent(map);
	}
	
}