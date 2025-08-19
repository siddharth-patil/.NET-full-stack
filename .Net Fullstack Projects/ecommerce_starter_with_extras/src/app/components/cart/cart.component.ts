import { Component } from '@angular/core';
import { CartService, CartItem } from '../../services/cart.service';

@Component({ selector: 'app-cart', templateUrl: './cart.component.html' })
export class CartComponent {
  items: CartItem[] = [];
  constructor(private cart: CartService){ this.items = cart.getItems(); }
  remove(id: number){ this.cart.removeFromCart(id); this.items = this.cart.getItems(); }
  clear(){ this.cart.clear(); this.items = []; }
  total(){ return this.items.reduce((s,i)=> s + i.product.price * i.qty, 0); }
}
