import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { CountryCodePipe } from '../pipe/country-code-pipe';
import { CurrencyConvertorPipe } from '../pipe/currency-convertor-pipe';

@Component({
  selector: 'app-order',
  imports: [CommonModule,CountryCodePipe],
  templateUrl: './order.html',
  styleUrl: './order.css'
})
export class Order {
  orderArr:any[]=[
    {
      "orderNo":101,
      "orderDate":"20-feb-2002",
      "customerName":"George",  
      "contactNo":"898655444",
      "country":"Germany",
      "orderStatus":"pending"
    },
    {
      "orderNo":102,
      "orderDate":"27-feb-2000",
      "customerName":"Siddharth",  
      "contactNo":"1234567890",
      "country":"India",
      "orderStatus":"processed"
    },
    {
      "orderNo":103,
      "orderDate":"20-mar-2022",
      "customerName":"Davide",  
      "contactNo":"898655444",
      "country":"Italy",
      "orderStatus":"cancelled"
    }
  ];
}
