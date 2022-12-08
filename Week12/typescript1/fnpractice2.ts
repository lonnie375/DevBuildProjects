// COmpare the results of a function to the function itself 
// Analogy: 
//     Using a real-world object vs 
//     Buying that real-world object and giving it to somebody as a gift 
//
//    I can use my Korg Synthesizer 
//           OR 
//     I can buy my sister a Korg Synthesizer and give it to her 
// ====================================================================
//     I can ask my coffee maker to give me coffee 
//           OR 
//     I can buy a coffee maker and gift it to somebody 
// ====================================================================
//     I* can have my coffee maker make a cup and i can give the cup to my sister 
//           OR
//     I can buy a coffee maker and give it to my sister and... 
// 


// This function takes two numbers, adds them, and returns the sum 
// let Add = (x: number, y: number): number => {
//     return x + y; 
// }; 

// let sum = Add(5,10); 
// console.log(sum);

// Let's create a function that makes a cup of coffee. 


function MakeCup(brand) {
    return `One cup of ${brand}`; 
}

let cup1 = MakeCup('Starbucks'); 
console.log(cup1);

// let cup2 = MakeCup('Folgers'); 
console.log(MakeCup('Folgers')); // I called the funcation and got back a string ' One cup of Folgers' and I sent that result to console.log

function sendCoffeeMaker(machine){
let cup = machine("Peets"); 
console.log(cup);
}

sendCoffeeMaker(MakeCup);





// It's a super-simply function that we pass in a string and it makes a new string 
// and gives that new string back to us