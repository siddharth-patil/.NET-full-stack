import { Component, OnInit } from '@angular/core';
import { CartService } from '../../services/cart.service';
import { AuthService } from '../../services/auth.service';

@Component({ selector: 'app-header', templateUrl: './header.component.html' })
export class HeaderComponent implements OnInit {
  cartCount = 0;
  user: string | null = null;
  constructor(private cart: CartService, private auth: AuthService) {}
  ngOnInit() { 
    this.cart.count$.subscribe(c => this.cartCount = c);
    this.user = this.auth.getUser();
  }
  logout() { this.auth.logout(); window.location.href = '/'; }
}
