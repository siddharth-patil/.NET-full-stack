import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProductService } from '../../services/product.service';
import { CartService } from '../../services/cart.service';
import { Product } from '../../models/product';

@Component({ selector: 'app-product-detail', templateUrl: './product-detail.component.html' })
export class ProductDetailComponent implements OnInit {
  product?: Product;
  constructor(private route: ActivatedRoute, private ps: ProductService, private cart: CartService) {}
  ngOnInit(){
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.ps.getProducts().subscribe(list => this.product = list.find(p => p.id === id));
  }
  add(){ if(this.product) this.cart.addToCart(this.product,1); }
}
