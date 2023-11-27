/* this class stores gamecanvas, all game logic have it's base here
main methods are used there, objects are placed here
the class contains gameloop definition

init.js use init() method that is definded and modified right here*/

class Overworld{
	constructor(config){
		this.element = config.element;
		this.canvas = this.element.querySelector(".game-canvas");
		this.ctx = this.canvas.getContext("2d");
		this.map = null;
		this.heroData = null;
	}
	
	
	//GamLoop function
	startGameLoop(){
		const step = () => {
			
			//clearing canvas at the start of the next frame
			this.ctx.clearRect(0,0, this.canvas.width, this.canvas.height);
			
			//Establish the camera object
			//For now I don't now how to resolve it in multiplayer
			//how to detect individual players there?
			const cameraPerson = this.map.gameObjects.hero;
			//update all objects
			//drawing have to be done after updating objects
			//so drawing methods are below
			Object.values(this.map.gameObjects).forEach(object => {
				object.update({ //updating gameObjects
					arrow: this.directionInput.direction, //updating movement direction
					map: this.map, //referance to map
				})
			})

			//draw lower layer of the map
			this.map.drawLowerImage(this.ctx, cameraPerson);
			
			//draw "center" layer, all game objects
			Object.values(this.map.gameObjects).forEach(object => {
				object.sprite.draw(this.ctx, cameraPerson, object.isHeroBehindObject);
			})
			
			//draw lower layer of the map
			this.map.drawUpperImage(this.ctx, cameraPerson);
			
			
			requestAnimationFrame(() => {
				step();
			})
		}
		step();
	}
	
	getHero() {
		return app.get(apiBaseUrl + "Hero")
		  .then(response => {

			const data = response.data;
			//console.log(data)
			return data
		  })
		  .catch(error => {
			console.error('Error fetching data:', error);
		   });
	  }
	
	//async to fetch the data with getHero(), otherwise this.heroData will be null
	async init(){
		this.heroData = await this.getHero()
		console.log(this.heroData)

 
		this.map = new OverworldMap(window.OverworldMaps.Home); //loading current map
		this.map.mountObjects(); //mounting objects collisions
		this.directionInput = new DirectionInput(); //directionInput object constructor
		this.directionInput.init(); //running movement function
		
		this.startGameLoop();
	}
}
