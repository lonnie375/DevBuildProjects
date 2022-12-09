import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit {

  @Output() sender: EventEmitter<string> = new EventEmitter<string>(); 

  sendMessage(){
    this.sender.emit("Hello!");
  }
  constructor() { }

  ngOnInit(): void {
  }

}
