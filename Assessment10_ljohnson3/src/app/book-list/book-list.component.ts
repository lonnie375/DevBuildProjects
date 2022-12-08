import { Component, OnInit } from '@angular/core';
import { Book } from '../book';
import { BookService } from '../book.service';

@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css']
})
export class BookListComponent implements OnInit {

  constructor(public BookService: BookService) { }

  ngOnInit(): void {
  }

  //Variables to add 
  newTitle = ''; 
  newAuthor = '';
  newPubYear = 0; 

  addBook(){
    this.BookService.getBooks().push({
      title: this.newTitle, 
      author: this.newAuthor, 
      publicationYear: this.newPubYear
    }); 

    this.newTitle = ''; 
    this.newAuthor = ''; 
    this.newPubYear = 0; 
  }

  deleteBook(selection: Book){
    for (let i = 0; i < this.BookService.getBooks().length; i++){
      if (this.BookService.getBooks()[i] == selection){
        this.BookService.getBooks().splice(i,1); 
        return; 
      }
    }
  }


}
