import { AfterContentChecked, AfterContentInit, AfterViewChecked, AfterViewInit, Component, ContentChild, DoCheck, ElementRef, Input, OnChanges, OnDestroy, OnInit, SimpleChanges, ViewChild, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-server-element',
  templateUrl: './server-element.component.html',
  styleUrls: ['./server-element.component.css'], 
  //using encapsulation, view Encapsulation will change the control you have over styling your components
  // there is emulated which aligns with Angular. There is also None, and Shadow
  encapsulation: ViewEncapsulation.Emulated
})
  //ngOnInIt is a LifeCycle hook 
  // They are used to check pieces of your code 
  // Some of them are 
  // ---ngOnChanges - called after a bound input property changes => decorated with @input 
  // ---ngOnInit -- called once the component is initialized 
  // ---ngDoCheck -- called during every change detection run 
  // ---ngAfterContentInit -- Called after content (ng-content) has been projected in view 
  // ---ngAfterContentChecked -- called every time the projected content has been checked  
  // ---ngAfterViewInIt -- Called after the components view (and child views) has been initialized
  // ---ngAfterViewChecked -- Called every time the view (and child views) have been checked 
  // ---ngOnDestroy -- Called once the component is about to be destroyed

export class ServerElementComponent implements OnInit, OnChanges, DoCheck, AfterContentChecked, AfterContentInit, AfterViewInit, AfterViewChecked, OnDestroy {
//by adding @Input we are exposing this to the world so any parent component 
// can bind to element 
  @Input('srvElement') element: {type: string, name: string, content: string};
  @Input () name: string; 
  @ViewChild('heading') header: ElementRef; 
  @ContentChild('contentParagraph', {static: true}) paragraph: ElementRef; 

  constructor() { 
    console.log('constructor called');
  }
  ngOnChanges(changes: SimpleChanges) {
    console.log('constructor called');
  }

  ngOnInit() {
    console.log('ngOnInIt called!');
    console.log('Text Content: ' + this.header.nativeElement.textContent);
  }

  ngDoCheck() {
    console.log('ngDoCheck Called!');
  }

  ngAfterContentInit(){
    console.log('ngAfterContentInit');
  }

  ngAfterContentChecked() {
    console.log('ngAfterContentChecked');
  }

  ngAfterViewInit() {
    console.log('ngAfterViewInit');
    console.log('Text Content: ' + this.header.nativeElement.textContent);
  }
  ngAfterViewChecked() {
    console.log('ngAfterViewChecked');
  }

  ngOnDestroy() {
    console.log('ngOnDestroy called!');
  }
}
