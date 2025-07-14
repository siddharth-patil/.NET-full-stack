import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Order } from "./order/order";
import { CountryCodePipe } from './pipe/country-code-pipe';
import { CurrencyConvertorPipe } from './pipe/currency-convertor-pipe';

@Component({
  selector: 'app-root',
  imports: [CommonModule,Order,CurrencyConvertorPipe],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'Pipe_Demo';

  amount:number=123.445;
  jdate:Date = new Date(2000,2,27);

  person={
    fname:'siddharth',
    lname:'patil',
    gender:'male'
  };

  amountInDollar:number=10;
}
