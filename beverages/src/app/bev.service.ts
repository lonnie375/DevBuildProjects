import { Injectable } from '@angular/core';
import { Beverage } from './beverage';

@Injectable({
  providedIn: 'root'
})
export class BevService {

  TheList: Beverage[] = [
    {name: 'Pepsi', alcohol: false, size: 20}, 
    {name: 'Founders Porter', alcohol: true, size: 16}
  ]

  // Add A getter function so that you can get the list after you have injected it 
  get(): Beverage[] {
    return this.TheList; 
  }
  constructor() { }
}
