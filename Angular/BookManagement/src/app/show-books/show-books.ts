import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Book } from '../Model/book';
import { BookService } from '../Service/book-service';

@Component({
  selector: 'app-show-books',
  imports: [CommonModule,FormsModule],
  templateUrl: './show-books.html',
  styleUrl: './show-books.css'
})
export class ShowBooks {
  books:Book[] =[];

  constructor(private bookService:BookService){}
  
  ngOnInit(){
    this.books = this.bookService.getBooks();
  }

  deleteBook(bookId:number):void{
    this.bookService.deleteBook(bookId);
    this.books = this.bookService.getBooks();
  }
}
