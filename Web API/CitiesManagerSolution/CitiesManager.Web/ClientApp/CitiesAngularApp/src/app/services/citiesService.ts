import { Injectable } from '@angular/core';
import {City} from '../models/city';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CitiesService {
  cities: City[] = [];

  // constructor() {
  //   this.cities = [
  //    new City(101, 'New York'),
  //    new City(102, 'Los Angeles'),
  //    new City(103, 'New Delhi'),
  //    new City(104, 'Mumbai'),
  //   ];
  // }
   constructor(private httpClient:HttpClient) {

  }

  public getCities(): Observable<City[]> {
    // return this.cities;
    return this.httpClient.get<City[]>("https://localhost:7252/api/v1/cities");
  }
}
