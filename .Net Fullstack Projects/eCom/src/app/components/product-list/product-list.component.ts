import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../services/product.service';
import { CartService } from '../../services/cart.service';
import { Product } from '../../models/product';

@Component({ selector: 'app-product-list', templateUrl: './product-list.component.html' })
export class ProductListComponent implements OnInit {
  products: Product[] = [];
  filtered: Product[] = [];
  loading = true;
  search = '';
  categories: string[] = [];
  selectedCategory = 'All';

  constructor(private ps: ProductService, private cart: CartService) {}
  ngOnInit(){
    this.ps.getProducts().subscribe(p => {
      this.products = p;
      this.filtered = p;
      this.categories = Array.from(new Set(p.map(x => x.category))).filter(Boolean);
      this.categories.unshift('All');
      this.loading = false;
    });
  }
  add(product: Product){ this.cart.addToCart(product, 1); }
  applyFilters(){
    const s = this.search.trim().toLowerCase();
    this.filtered = this.products.filter(p => {
      const matchesCategory = this.selectedCategory === 'All' || p.category === this.selectedCategory;
      const matchesSearch = !s || (p.name + ' ' + (p.description||'') + ' ' + (p.category||'')).toLowerCase().includes(s);
      return matchesCategory && matchesSearch;
    });
  }
}
