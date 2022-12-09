import { Component, OnInit } from '@angular/core';
import { BevService } from '../bev.service';
import { Beverage } from '../beverage';

@Component({
  selector: 'app-bev-list',
  templateUrl: './bev-list.component.html',
  styleUrls: ['./bev-list.component.css']
})
export class BevListComponent implements OnInit {

  //Injecting the list we created in our service here. 
  //We will be able to use BevSrc to access that in this component. 
  // Variables for the inputs for a new beverage
  newName: string = ''; 
  newAlcohol: boolean = false; 
  newSize: number = 0; 
  //Anytime we need the list, we say 
  // this.BevSrc.get()
  constructor(public BevSrc: BevService) { }

  ngOnInit(): void {
  }

  delete(whichBev: Beverage){
      for (let i = 0; i < this.BevSrc.get().length; i++){
        if (this.BevSrc.get()[i] == whichBev){
          this.BevSrc.get().splice(i, 1);
          return; 
        }
      }
  }

  addOne(){
    //Add the items from the inputs to our list
    
    this.BevSrc.get().push(
      {
        name: this.newName, 
        alcohol: this.newAlcohol, 
        size: this.newSize
      }
    );

    //After the users input is added to the list
    //make sure the input boxes are cleared out
    this.newName = '';
    this.newAlcohol = false; 
    this.newSize = 0; 
  }

}
