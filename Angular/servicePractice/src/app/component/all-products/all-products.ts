import { Component } from '@angular/core';
import { IProduct } from '../../interfaceORclasses/IProduct';
import { Product } from '../../services/product';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  selector: 'app-all-products',
  imports: [CommonModule,RouterLink],
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

  deleteProduct(productData:IProduct){
    console.log(productData);

    this.product.delete_Product(productData);

    this.products = this.product.getAllProducts();
  }

}
