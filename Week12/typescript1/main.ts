// e put in curlies the interface (or class, or whatever) that 
// want to import from the file that's inside quotes. 
import { Interface } from "readline";
import { Circle } from "./circle";

class Figures {
    circles: Circle[] = []; //member called circle

    //method that adds circles
    addCircule(mycircle: Circle) {
        this.circles.push(mycircle);
    }

    //print out the circles that we created 
    listCircles(){
        for (let next of this.circles){
            console.log(`The ${next.fillColor} circle has area ${next.radius * next.radius * 3.1415}`); 
        }
    }
}

let myfigures = new Figures(); 
myfigures.addCircule({
    radius: 5, fillColor: 'Blue', lineColor: 'black', lineWeight: 2
}); 

myfigures.addCircule({
    radius: 6.5, fillColor: 'red', lineColor: 'darkred', lineWeight: 3
}); 
myfigures.listCircles(); 