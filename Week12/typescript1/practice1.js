"use strict";
let age = 15;
console.log(age);
//This is a traditional function
function add(x, y) {
    return x + y;
}
//Anonymous function 
let Add2 = function (x, y) {
    return x * y;
};
// This is an arrow function 
let Multiply = (x, y) => {
    return x * y;
};
console.log(Multiply(6, 5));
// When you ONLY  have one line in the function and it's a return statement 
// you can leave off the curling and the word return: 
let Mult2 = (x, y) => x * y;
console.log(Mult2(10, 20));
// Let's set up an interval. It will run a function every three seconds. 
let hello = () => {
    console.log("Hello");
};
// hello(); 
// I'm going to call a function called setInterval. I'm going to hand over 
// to it two things: 
//   1. A function to call, in this Hello 
//   2. A number of milliseconds of how long to wait between calls 
// setInterval will then call that function every so many milliseconds 
// Lets do the Hello function every 3000 milliseconds (that's 3 seconds)
// To "hand over things " to a function, we pass them as parameters 
// Don't put parenthesis after hello. Leaving them off means we're handing 
// over the function itself (as opposed to the results of the function). 
// setInterval(hello, 3000); //hello is the name of our function above 
// 3000 is the time we want to pass before 
// we run the function again. hello is going to 
// run every 3 seconds. 
// here is a website where you can learn more about the 
// "setInterval" method that TypeScript provides https://www.educba.com/setinterval-typescript/
// setInterval(
//     () => {
//         console.log('Hello!!!'); 
//     }, 3000
// );
// This concept transcends all of JavaScript (including TypeScript) development. 
console.log("Hello");
