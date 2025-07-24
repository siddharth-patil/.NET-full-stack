import { Component } from '@angular/core';
import { IProduct } from '../../interfaceORclasses/IProduct';
import { Product } from '../../services/product';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-all-products',
  imports: [CommonModule],
  templateUrl: './all-products.html',
  styleUrl: './all-products.css'
})
export class AllProducts {

  products:IProduct[] = [];

  constructor(private product:Product) {
    
  }

  ngOnInit(){
    this.products = this.product.getAllProducts();
  }

}
