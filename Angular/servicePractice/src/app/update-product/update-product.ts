import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { IProduct } from '../interfaceORclasses/IProduct';
import { Product } from '../services/product';

@Component({
  selector: 'app-update-product',
  imports: [CommonModule,FormsModule,ReactiveFormsModule],
  templateUrl: './update-product.html',
  styleUrl: './update-product.css'
})
export class UpdateProduct {
  Product:IProduct|undefined;

  productData = new FormGroup({
    productId:new FormControl<number|null>(null),
    productName:new FormControl<string|null>(null),
    productPrice:new FormControl<number|null>(null),
    productQuantity:new FormControl<number|null>(null)
  });

  constructor(private routes:ActivatedRoute,private productService:Product){

    const id = Number(this.routes.snapshot.paramMap.get('id'));

    this.Product = this.productService.getProductById(id);

    if(this.Product){
      this.productData.patchValue(this.Product);
    }
  }

  updateProduct(){
    console.log(this.productData.value);

    this.productService.updateProduct(this.productData);
    
  }
}
