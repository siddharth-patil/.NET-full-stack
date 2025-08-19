import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../models/product';

@Injectable({ providedIn: 'root' })
export class ProductService {
  private url = 'assets/products.json';
  constructor(private http: HttpClient) {}
  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.url);
  }
}
