import { Component, OnInit } from '@angular/core';
import { Hero } from '../hero';
import { HeroService } from '../hero.service';
import { MessageService } from '../message.service';

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {

  heroes: Hero[] = []; 

  selectedHero?: Hero; 
  

  constructor(private heroService: HeroService, private messageService: MessageService) { }

  ngOnInit(): void {
    this.getHeroes();
  }

  onSelect(hero: Hero): void {
    this.selectedHero = hero; 
    this.messageService.add('HeroesComponent: Selected hero id=${hero.id}');
  }

  //Creating a method to access the service details
  //This takes the array we created above "Heroes"
  //and assigns it the values from the mock class of HEROES. 
  //This method speaks to the service getHeroes2 method which returns the HEROES
  //we assign those HEROES to our heroes array!!
  getHeroes(): void {
    this.heroService.getHeroes2()
        .subscribe(heroes => this.heroes = heroes);
  }

}
