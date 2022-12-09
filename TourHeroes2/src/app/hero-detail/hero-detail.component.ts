import { Component, OnInit, Input, Output } from '@angular/core';
import { Hero } from '../hero';

@Component({
  selector: 'app-hero-detail',
  templateUrl: './hero-detail.component.html',
  styleUrls: ['./hero-detail.component.css']
})
export class HeroDetailComponent implements OnInit {

  //This is done so that we can receive a Hero from the parent component 
  // heroes.component is the parent component
  // hero-detail is the child component 
  
  @Input() hero?: Hero; 

  constructor() { }

  ngOnInit(): void {
  }

}
