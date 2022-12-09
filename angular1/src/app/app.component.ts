import { Component } from '@angular/core';
import { City } from './city';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Runaway';
  name = 'Sally';
  newCity = ''; 
  cities: string[] = [
    'Detroit', 
    'Chicago',
    'New York', 
    'Orlando', 
    'Salt Lake City'
  ]

  addCity(){
    this.cities.push(this.newCity);
    this.newCity = ''; //This will make sure that the input box is blank after you enter your city
    this.name = 'Fred'; 
  }

  // addCity(){
  //   this.name = 'Robert';
  // }


  //We are going to be using the City Interface that we created
  moreCities: City[]= [
    {
      name: 'Detroit', 
      state: 'Michigan', 
      population: 5000000
    }, 
    {
      name: 'New York', 
      state: 'New York', 
      population: 1000000
    }, 
    {
      name: 'Lansing', 
      state: 'Michigan', 
      population: 100000
    }
  ]

}
