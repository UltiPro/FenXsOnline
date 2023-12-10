const utils = { 
	//used for grid-based movement
	withGrid(n){
		return n * 32; //n -> position * 16 -> grid pixel size
	},
	//used for calculating collisions, return gird placement
	asGridCoord(x, y) { 
		return `${x * 32},${y * 32}`;
	},

	//calculating collisions
	nextPosition(initialX, initialY, direction){
		let x = initialX;
		let y = initialY;
		const size = 32;
		if(direction === "left"){
			x -= size;
		}
		else if(direction === "right"){
			x += size;
		}
		else if(direction === "up"){
			y -= size;
		}
		else if(direction === "down"){
			y += size;
		}
		return {x,y};
	},
	oppositeDirection(direction){
		if(direction === "left"){return "right"}
		if(direction === "right"){return "left"}
		if(direction === "up"){return "down"}
		return "up"
	},


	emitEvent(name, detail){
		const event = new CustomEvent(name, {
			detail
		});
		document.dispatchEvent(event);
	}
	
}
