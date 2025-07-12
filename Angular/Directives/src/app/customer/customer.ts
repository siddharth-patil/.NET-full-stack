import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-customer',
  imports: [CommonModule],
  templateUrl: './customer.html',
  styleUrl: './customer.css'
})
export class Customer {

  Customers = [
    {
      custId:101,
      custName:'davide',
      country:'Italy',
      city:'Turin',
      contact:123456789
    },
    {
      custId:102,
      custName:'steve',
      country:'USA',
      city:'California',
      contact:987654321
    },
    {
      custId:103,
      custName:'Megha',
      country:'India',
      city:'Kolkata',
      contact:192837465
    },
    {
      custId:104,
      custName:'Rosa',
      country:'Turkey',
      city:'abcd',
      contact:543216789
    },
    {
      custId:105,
      custName:'Kardelene',
      country:'Turkey',
      city:'xyz',
      contact:543216789
    }
  ];


}
