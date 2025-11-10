import { ShopService } from './core/services/shop.service';
import { Component, inject, OnInit } from '@angular/core';
import { Router, RouterOutlet } from '@angular/router';
import { HeaderComponent } from "./layout/header/header.component";
import { HttpClient } from '@angular/common/http';
import { Product } from './shared/models/product';
import { Pagination } from './shared/models/pagination';
import { ShopComponent } from "./features/shop/shop.component";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, HeaderComponent, ShopComponent],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App{
  
  // baseUrl = 'https://localhost:7068/api/';
  // private http = inject(HttpClient);
  // private shopService = inject(ShopService);
  protected title = 'skinet';
  // products : Product[] = [];
  // constructor(private http : HttpClient){}

  // ngOnInit(): void {
  //   // this.http.get<Pagination<Product>>(this.baseUrl + 'products').subscribe
  //   this.shopService.getProducts().subscribe({
  //     next: response => this.products = response.data,
  //     error: error=>console.log(error)
  //   })
  // }
}
