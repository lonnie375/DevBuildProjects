"use strict";
let numbers = [5, 6, 10, 3, 2];
// Loop version 1: for loop 
console.log('Regular for loop');
for (let i = 0; i < numbers.length; i++) {
    console.log(numbers[i] * 2);
}
// Loop version 2: forEach with separate function 
console.log('forEach version 1');
let f1 = (p) => {
    console.log(p * 2);
};
// console.log(f1(10)); 
numbers.forEach(f1);
// Loop version 3: forEach with function inside the forEach statement 
console.log('forEach version2');
numbers.forEach((p) => {
    console.log(p * 3);
});
// Loop version 4: for-of
console.log('for-of version 4');
for (let num of numbers) {
    console.log(num * 4);
}
