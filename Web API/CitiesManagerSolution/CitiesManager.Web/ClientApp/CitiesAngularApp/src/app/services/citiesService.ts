import { Injectable } from '@angular/core';
import { City } from '../models/city';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

const API_BASE_URL = 'https://localhost:7252/api/';

@Injectable({
  providedIn: 'root',
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
  constructor(private httpClient: HttpClient) {}

  public getCities(): Observable<City[]> {
    // return this.cities;

    let headers = new HttpHeaders();
    headers = headers.append('Authorization', 'Bearer mytoken');

    return this.httpClient.get<City[]>(`${API_BASE_URL}v1/cities`, {
      headers: headers,
    });
  }

  public postCities(city: City): Observable<City> {
    // return this.cities;

    let headers = new HttpHeaders();
    headers = headers.append('Authorization', 'Bearer mytoken');

    return this.httpClient.post<City>(`${API_BASE_URL}v1/cities`, city, {
      headers: headers,
    });
  }

  public putCity(city: City): Observable<string> {
    let headers = new HttpHeaders();
    headers = headers.append('Authorization', 'Bearer mytoken');

    return this.httpClient.put<string>(`${API_BASE_URL}v1/cities/${city.cityID}`, city, {
      headers: headers,
    });
  }

  public deleteCity(cityID: string | null): Observable<string> {
    let headers = new HttpHeaders();
    headers = headers.append('Authorization', 'Bearer mytoken');

    return this.httpClient.delete<string>(`${API_BASE_URL}v1/cities/${cityID}`,{
      headers: headers,
    });
  }
}
