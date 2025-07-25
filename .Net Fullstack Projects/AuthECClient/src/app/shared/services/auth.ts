import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class Auth {

  baseURL:string = '';

  constructor(private http:HttpClient){
    this.baseURL = 'http://localhost:5038/api';
  }

  createUser(formData:any){
    return this.http.post(this.baseURL+'/signup',formData)
  }
}
