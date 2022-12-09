import { Component, OnInit, Input } from '@angular/core';
import { City } from '../city';
import { AppComponent } from '../app.component';
import { outputAst } from '@angular/compiler';

@Component({
  selector: 'app-city',
  templateUrl: './city.component.html',
  styleUrls: ['./city.component.css']
})
export class CityComponent implements OnInit {
 
 @Input() theCity: City = {
    name: '', 
    state: '', 
    population:0
  }

  constructor() { }

  ngOnInit(): void {
  }



}
