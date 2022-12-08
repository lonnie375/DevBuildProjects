
// Add export to your class to make the class available in other files
// This is also known as a module 
export class Rectangle {
    length: number; 
    width: number;

    constructor(_length: number, _width: number) {
        this.length = _length; 
        this.width = _width; 
    }
    
    getArea():number {
        return this.length * this.width; 
    }
}

//Lets make a new instance of Rectangle 
let r1 = new Rectangle(20, 30);
console.log(r1);  
console.log(r1.getArea()); 