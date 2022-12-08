interface Car {
    make: string; 
    model: string; 
    year: Number
}; 

let car1: Car = {
    make: 'Ford', 
    model: 'Mustang', 
    year: 1965
}; 

let car2: Car = {
    make: 'Chevy', 
    model: 'Trax', 
    year: 2018
}; 

let car3: Car = {
    make: 'Honda', 
    model: 'Civic LX', 
    year: 2002
}; 

console.log(car1);
console.log(car2);
console.log(car3);

// Let's make an array of these 
// FIrst without a type, e.g. JavaScript style 

let thing = {
    make: 1000, 
    model: 'Hello', 
    size: 50
};

//We aren't going to save them as a type
// The database would choke if it was expecting a certain type
// The thing would cause the issue because there isn't a size, 
// Also, make is supposed to be a string
let stuff = [car1, car2, car3, thing]; 

console.log(stuff);

let cars: Car[] = [car1, car2, car3, thing]; 
console.log(cars);

// An interface is a shape (or cookie cutter or mold, etc) of an object. 
// When we declare a variable of having it as a type, TypeScript will stop 
// us from putting the wrong members in it. If we use it for an array 
// TypeScript will stop us from putting an object in the array that 
// doesn't fit the mold. 