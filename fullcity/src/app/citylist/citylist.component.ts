import { Component, OnInit } from '@angular/core';
import { City } from '../city';

@Component({
  selector: 'app-citylist',
  templateUrl: './citylist.component.html',
  styleUrls: ['./citylist.component.css']
})
export class CitylistComponent implements OnInit {

  cities: City [] = [
    { name: 'Grand Rapids', state: 'Michigan', population: 197000}, 
    { name: 'Traverse City', state: 'Michigan', population: 15550}
  ];

  NewName: string = ''; 
  NewState: string = ''; 
  NewPopulation: number = 0; 
  showAdd = false; 
  constructor() { }

  ngOnInit(): void {
  }
  showAddForm(){
    this.showAdd = false; 
  }

  add(){
    this.cities.push({
      name: this.NewName, 
      state: this.NewState, 
      population: this.NewPopulation
    }); 
    this.NewName= ''; 
    this.NewState= '', 
    this.NewPopulation= 0, 
    this.showAdd = true;
  }

  cancel(){
    this.NewName= ''; 
    this.NewState= '', 
    this.NewPopulation= 0, 
    this.showAdd = true;
  }

  removeItem(whichCity: City){
    //alert(whichCity.name);
    // Loop through the list and look for the one that matches
    // Once we find it we will then remove it 
    for (let index = 0; index < this.cities.length; index++){
       if(this.cities[index] == whichCity) {
        this.cities.splice(index,1); 
        return; // Get out of the function altogether
       }
    }
  }



}
