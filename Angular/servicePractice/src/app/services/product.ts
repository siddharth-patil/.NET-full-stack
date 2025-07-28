import { Injectable } from '@angular/core';
import { IProduct } from '../interfaceORclasses/IProduct';

@Injectable({
  providedIn: 'root'
})
export class Product {
  arrProduct:IProduct[] = [
    {
      productId:101, productName:'Mobile', productPrice:30000, productQuantity:9
    },
    {
      productId:101, productName:'Laptop', productPrice:130000, productQuantity:6
    },
    {
      productId:101, productName:'TV', productPrice:20000, productQuantity:10
    }
  ];

  getAllProducts():IProduct[]{

    return this.arrProduct;
  }

  delete_Product(product:IProduct){
    console.log(product);
    for (let index = 0; index < this.arrProduct.length; index++) {
      if(this.arrProduct[index].productId === product.productId){
        this.arrProduct.splice(index,1);
        break;
      }
      
    }
    
  }

  addProduct(prod:IProduct){
    this.arrProduct.push(prod);
  }
}
