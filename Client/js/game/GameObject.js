class GameObject{
	constructor(config){
		this.isMounted = false;
		this.x = config.x || 0;
		this.y = config.y || 0;
		this.direction = config.direction || "down";
		this.sprite = new Sprite({
			gameObject: this,
			src: config.src || "./assets/heroes/hunter/hunterF0.gif",
		});
		
	}
	

	mount(map){
		this.isMounted = true;
		map.addWall(this.x, this.y);
	}
	//updating objects for ex. when they move
	update(){
		
		
	}
	
}