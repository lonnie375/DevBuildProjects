//We created a class in a model file that we created
//This is the format that we are going to use for all of our recipes
// The constructor is needed so that we can build/create more recipes 


export class Recipe {
    public name: string; 
    public description: string; 
    public imagePath: string; 

    constructor(name: string, desc: string, imagePath: string){
        this.name = name; 
        this.description = desc; 
        this.imagePath = imagePath; 
    }
}