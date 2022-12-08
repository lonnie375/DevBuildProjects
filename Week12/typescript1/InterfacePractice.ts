import { Product } from "./product";
import { Size } from "./product"; 

// Let's make some products and see what errors we get 
// If e do them wrong. 

// The error we get is "compile-time" error. We're supposed 
// to notice it while we're coding. 
// That's in contrast to a "run-time" error, which happens 
// when the program runs. 

let prod1: Product = {
    id: "WIDG", 
    name: "Widget", 
    description: "The best widget ever",
    price: 99.99, 
    inventory: 6, 

}; 

let PrintProduct = (myprod: Product) => {
        console.log(`${myprod.name} id ${myprod.id} ${myprod.price} `); 
        console.log(`${myprod.description}`); 
        console.log(`${myprod.inventory} in stock`); 
}


PrintProduct(prod1); 
// Let's make a list and again see what errors if we do it wrong 

let products: Product[] = []; 

products.push(prod1); 

products.push({
    id: "GADG", 
    name: "Gadget", 
    description: "Our top of the line Gadget", 
    price: 12.99, 
    inventory: 30
}); 

let PrintList = (prods : Product []) => {
    for (let prod of prods){
        PrintProduct(prod); 
    }
}

console.log('==All Products==');
PrintList(products);
// Quotes around property names in JSON??
// What about initialization? Null? 

// Initialization? it's messy, ugly, no fun 
// But we can use an "or" operator and list 
// multiple types for a variable. 
// let prod2: Product = null; //doesn't work 
// This makes the object being null and not having a value an option
let prod3: Product | null = null //this works 