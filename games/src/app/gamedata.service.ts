import { Injectable } from '@angular/core';
import { Game } from './game';

@Injectable({
  providedIn: 'root'
})
export class GamedataService {

  TheList: Game [] = [
    {title: 'Modern WarFare 2', year: 2022, console: true},
    {title: 'Vanguard', year: 2021, console: true}
  ]
  constructor() { }


  get(): Game[] {
    return this.TheList; 
  }
}
