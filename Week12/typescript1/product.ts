export interface Product {
    id: string; 
    name: string; 
    description: string; 
    price: number; 
    inventory: number; 
};

export interface Size {
    sizename: string,
    description: string 
}

// Later we can make a more advanced product that has objects inside objects 

// TypeScript looks at the members of an object 
// such as id, name etc., and if that object 
// has all those members, TypesScript says the 
// object can be considered that Type, in this 
// case Product. 
// That's how interfaces work: TypeScript just 
// makes sure it has the members you list 
// in the interface