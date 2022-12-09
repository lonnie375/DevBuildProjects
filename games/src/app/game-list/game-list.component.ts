import { Component, OnInit } from '@angular/core';
import { Game } from '../game';
import { GamedataService } from '../gamedata.service';

@Component({
  selector: 'app-game-list',
  templateUrl: './game-list.component.html',
  styleUrls: ['./game-list.component.css']
})
export class GameListComponent implements OnInit {

  //Variables to Add 
  newTitle = ''; 
  newYear = 0; 
  newConsole: boolean = false; 


  constructor(public GameService: GamedataService) { }

  ngOnInit(): void {
  }

  add(){
    this.GameService.get().push({
      title: this.newTitle, 
      year: this.newYear, 
      console: this.newConsole
    }); 
    this.newTitle = ''; 
    this.newYear = 0; 
    this.newConsole = false; 
  }

  deleteGame(selection: Game){
    for (let i = 0; i < this.GameService.get().length; i++){
      if (this.GameService.get()[i] == selection){
        this.GameService.get().splice(i,1); 
        return; 
      }
    }
  }

}
