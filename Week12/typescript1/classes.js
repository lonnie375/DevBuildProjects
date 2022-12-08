"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Rectangle = void 0;
// Add export to your class to make the class available in other files
// This is also known as a module 
class Rectangle {
    constructor(_length, _width) {
        this.length = _length;
        this.width = _width;
    }
    getArea() {
        return this.length * this.width;
    }
}
exports.Rectangle = Rectangle;
//Lets make a new instance of Rectangle 
let r1 = new Rectangle(20, 30);
console.log(r1);
console.log(r1.getArea());
