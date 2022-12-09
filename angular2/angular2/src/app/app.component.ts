import { Component } from '@angular/core';
import { City } from './city';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angular2';
  formShowing: boolean = false; 

  newCity:City = {
    name: '', 
    state: '', 
    population: 0
  }
  cities: City[] = [
    {
      name: 'Detroit', 
      state: 'Michigan', 
      population: 500000
    }, 
    {
      name: 'Grand Rapids', 
      state: 'Michigan', 
      population: 60000
    }, 
    {
      name: 'New York', 
      state: 'New York', 
      population: 4000000
    }
  ];

  addCity(){
    let nextCity: City = {
        name: this.newCity.name, 
        state: this.newCity.state, 
        population: this.newCity.population

    }
//This is shorthand of the above
    // let nextCity2: City = { ... this.newCity}

    this.cities.push(nextCity);
    this.newCity.name = '', 
    this.newCity.state = '', 
    this.newCity.population = 0; 

    this.formShowing = false; 
  }

  showForm(){
    this.formShowing = true; 
  }
  cancelAdd(){
    this.formShowing = false; 
    this.newCity.name = '', 
    this.newCity.state = '', 
    this.newCity.population = 0; 
  }
}
