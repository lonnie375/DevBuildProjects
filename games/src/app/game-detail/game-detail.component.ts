import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Game } from '../game';

@Component({
  selector: 'app-game-detail',
  templateUrl: './game-detail.component.html',
  styleUrls: ['./game-detail.component.css']
})
export class GameDetailComponent implements OnInit {

  @Input() TheGame: Game = {
    title: 'Madden 2023', 
    year: 2022, 
    console: false
  }

  editMode: boolean = false; 
  changeTitle = ''; 
  changeYear = 0; 
  changeConsole: boolean = false; 

  console = false; 

  @Output() delete: EventEmitter<Game> = new EventEmitter<Game>(); 

  constructor() { }

  ngOnInit(): void {
  }

  editGame(){
    this.editMode = true; 

    this.changeTitle = this.TheGame.title; 
    this.changeYear = this.TheGame.year; 
    this.changeConsole = this.TheGame.console; 
  }

  cancel(){
    this.editMode = false; 
  }

  saveGame(){
    this.TheGame.title = this.changeTitle; 
    this.TheGame.year = this.changeYear; 
    this.TheGame.console = this.changeConsole; 
    this.editMode = false; 
  }

  deleteGame(){
    this.delete.emit(this.TheGame); 
  }

}
