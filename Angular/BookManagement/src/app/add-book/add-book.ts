import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Book } from '../Model/book';
import { BookService } from '../Service/book-service';

@Component({
  selector: 'app-add-book',
  imports: [CommonModule,FormsModule],
  templateUrl: './add-book.html',
  styleUrl: './add-book.css'
})
export class AddBook {

  book:Book = {
    bookId:0,
    title:'',
    author:'',
    price:0
  };

  constructor(private bookService:BookService){}

  onSubmit(){
    this.bookService.addBook(this.book); 
    this.book = {bookId:0,title:'',author:'',price:0};
    alert('Book added!');
  }
}
