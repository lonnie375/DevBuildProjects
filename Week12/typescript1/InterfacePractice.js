"use strict";
exports.__esModule = true;
// Let's make some products and see what errors we get 
// If e do them wrong. 
// The error we get is "compile-time" error. We're supposed 
// to notice it while we're coding. 
// That's in contrast to a "run-time" error, which happens 
// when the program runs. 
var prod1 = {
    id: "WIDG",
    name: "Widget",
    description: "The best widget ever",
    price: 99.99,
    inventory: 6
};
var PrintProduct = function (myprod) {
    console.log("".concat(myprod.name, " id ").concat(myprod.id, " ").concat(myprod.price, " "));
    console.log("".concat(myprod.description));
    console.log("".concat(myprod.inventory, " in stock"));
};
PrintProduct(prod1);
// Let's make a list and again see what errors if we do it wrong 
var products = [];
products.push(prod1);
products.push({
    id: "GADG",
    name: "Gadget",
    description: "Our top of the line Gadget",
    price: 12.99,
    inventory: 30
});
var PrintList = function (prods) {
    for (var _i = 0, prods_1 = prods; _i < prods_1.length; _i++) {
        var prod = prods_1[_i];
        PrintProduct(prod);
    }
};
console.log('==All Products==');
PrintList(products);
// Quotes around property names in JSON??
// What about initialization? Null? 
