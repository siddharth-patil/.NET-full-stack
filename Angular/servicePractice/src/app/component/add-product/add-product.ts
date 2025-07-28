import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { Product } from '../../services/product';

@Component({
  selector: 'app-add-product',
  imports: [ReactiveFormsModule],
  templateUrl: './add-product.html',
  styleUrl: './add-product.css'
})
export class AddProduct {

  constructor(private productService:Product){}

  product = new FormGroup({
    productId : new FormControl(''),
    productName : new FormControl(''),
    productPrice : new FormControl(''),
    productQuantity : new FormControl('')
  })

  addProduct(){
    console.log(this.product.value);
    
    const prod:any = this.product.value;
    this.productService.addProduct(prod);
  }
}
