import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Product } from '../models/product';

export interface CartItem { product: Product; qty: number }

@Injectable({ providedIn: 'root' })
export class CartService {
  private items: CartItem[] = [];
  private totalCount$ = new BehaviorSubject<number>(0);
  count$ = this.totalCount$.asObservable();

  addToCart(product: Product, qty = 1) {
    const found = this.items.find(i => i.product.id === product.id);
    if (found) found.qty += qty; else this.items.push({ product, qty });
    this.updateCount();
  }
  removeFromCart(productId: number) {
    this.items = this.items.filter(i => i.product.id !== productId);
    this.updateCount();
  }
  getItems() { return this.items; }
  clear() { this.items = []; this.updateCount(); }
  private updateCount() { this.totalCount$.next(this.items.reduce((s, i) => s + i.qty, 0)); }
}
