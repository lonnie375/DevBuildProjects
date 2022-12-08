import { Injectable } from '@angular/core';
import { Book } from './book';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  books: Book []= [
    {title: 'Tom Clancy Without Remorse', author: 'John Clark', publicationYear: 1994 },
    {title: 'A Tale of Two Cities', author: 'Charles Dickens', publicationYear: 1859 },
    {title: 'And Then We Were Done', author: 'Agatha Christie', publicationYear: 2011 }
  ]

  getBooks(): Book[] {
    return this.books; 
  }

  constructor() { }
}
