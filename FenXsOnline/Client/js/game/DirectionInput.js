class DirectionInput {
	constructor() {
		this.heldDirections = [];

		//maping actions to keys
		this.map = {
			"ArrowUp": "up",
			"KeyW": "up",
			"ArrowDown": "down",
			"KeyS": "down",
			"ArrowLeft": "left",
			"KeyA": "left",
			"ArrowRight": "right",
			"KeyD": "right",
		}
	}

	//updating movement direction
	get direction() {
		return this.heldDirections[0];
	}

	//initiating movement function
	init() {
		document.addEventListener("keydown", e => {
			const dir = this.map[e.code];
			if (dir && this.heldDirections.indexOf(dir) === -1) {
				this.heldDirections.unshift(dir);
				//console.log(e.code +"pressed");
			}
		});
		document.addEventListener("keyup", e => {
			const dir = this.map[e.code];
			const index = this.heldDirections.indexOf(dir);
			if (index > -1) {
				this.heldDirections.splice(index, 1);
				//console.log(e.code +"released");
			}
		})
	}
}