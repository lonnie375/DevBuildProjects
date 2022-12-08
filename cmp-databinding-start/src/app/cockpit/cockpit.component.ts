import { Component, ElementRef, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';

@Component({
  selector: 'app-cockpit',
  templateUrl: './cockpit.component.html',
  styleUrls: ['./cockpit.component.css']
})
export class CockpitComponent implements OnInit {
  //EventEmitter is only used for abstractions and only for emitting custom Events in components
  //@Output passes information from out of this component to another 
  @Output() serverCreated = new EventEmitter<{serverName: string, serverContent: string}>(); 
  @Output() blueprintCreated = new EventEmitter<{serverName: string, serverContent: string}>(); 
  newServerName = '';
  newServerContent = '';
  @ViewChild('serverContentInput', {static: true}) serverContentInput: ElementRef; 


  constructor() { }


  ngOnInit(): void {
  }

  // onAddServer() {
  //   // This creates a new eventEmitter with this type here 
  //   this.serverCreated.emit({serverName: this.newServerName, serverContent: this.newServerContent}); 
  // }
  // This is the first example - two way binding. Below we are using a local reference point

  //   onAddServer(nameInput: HTMLInputElement) {
    
  //   this.serverCreated.emit({serverName: nameInput.value, serverContent: this.newServerContent}); 
  // }
  // This was used with the second example - HTML local reference 

  onAddServer(nameInput: HTMLInputElement) {
    
      this.serverCreated.emit({serverName: nameInput.value, serverContent: this.serverContentInput.nativeElement.value}); 
    }


  // onAddBlueprint() {
  //   // This creates a new eventEmitter with this type here 
  //   this.blueprintCreated.emit({serverName: this.newServerName, serverContent: this.newServerContent}); 
  // }
  // This is the first example - two way binding. Below we are using a local reference point
  
  // onAddBlueprint(nameInput: HTMLInputElement) {
  //   this.blueprintCreated.emit({serverName: nameInput.value, serverContent: this.newServerContent}); 
  // }
  // This was for the second example - HTML local reference 

  onAddBlueprint(nameInput: HTMLInputElement) {
    this.blueprintCreated.emit({serverName: nameInput.value, serverContent: this.serverContentInput.nativeElement.value}); 
  }

}
