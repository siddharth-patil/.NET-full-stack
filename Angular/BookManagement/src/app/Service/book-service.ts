import { Injectable } from '@angular/core';
import { Book } from '../Model/book';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  private books:Book[] = [];

  getBooks(){
    return this.books;
  }

  addBook(book:Book){
    this.books.push(book);
  }

  deleteBook(bookId:number):void{
    this.books = this.books.filter(b=>b.bookId !== bookId);
  }
}
