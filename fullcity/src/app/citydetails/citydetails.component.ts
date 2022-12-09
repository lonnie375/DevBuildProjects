import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { City } from '../city';

@Component({
  selector: 'app-citydetails',
  templateUrl: './citydetails.component.html',
  styleUrls: ['./citydetails.component.css']
})
export class CitydetailsComponent implements OnInit {

  //Input information coming from the parent 
  @Input() TheCity: City = {
    name: 'Detroit', 
    state: 'Michigan', 
    population: 10000000
  }

  editMode = false; 

  changeName: string = ''; 
  changeState: string = ''; 
  changePop: number = 0; 

  // For the Delete, we need a thing called an event emitter. 
  // It's the messenger that will notify the parent (city-list)
  // that we want to be deleted

  // Information going back to the parent component
  @Output() remove: EventEmitter<City> = new EventEmitter<City>();

  constructor() { }

  ngOnInit(): void {
  }

  edit(){
    this.editMode = true;
    this.changeName = this.TheCity.name; 
    this.changeState  = this.TheCity.state; 
    this.changePop = this.TheCity.population; 
  }



  saveChanges(){
    this.editMode = false; 
    this.TheCity.name = this.changeName; 
    this.TheCity.state = this.changeState; 
    this.TheCity.population = this.changePop; 
  }

  cancelChanges(){
    this.editMode = false; 
  }

//Sending the data up to the parent to be deleted 
// the message is being emitted 
  deletes(){
    this.remove.emit(this.TheCity);
  }

}
