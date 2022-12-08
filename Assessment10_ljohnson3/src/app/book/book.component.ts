import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Book } from '../book';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {

  @Input() TheBook: Book = {
    title: '', 
    author: '', 
    publicationYear: 0
  }

  @Output() delete: EventEmitter<Book> = new EventEmitter<Book>(); 
  

  constructor() { }

  ngOnInit(): void {
  }

  deleteBook(){
    this.delete.emit(this.TheBook); 
  }

}
