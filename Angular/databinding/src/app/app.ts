import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';
import { Calculator } from "./calculator/calculator";
import { City } from './city/city';

@Component({
  selector: 'app-root',
  imports: [CommonModule, FormsModule,Calculator,City],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'databinding';
  username:string = 'siddharth';

  imgUrl:string = 'img1.jfif';
  width:number=200;
  height:number=200;

  greet(){
    alert("Helloo " + this.username);
  }


  username1:string = 'Ram';

  firstName:string="virat";
  lastName:string='kohli';
  fullName:string='';

  generateFullName(){
    this.fullName = this.firstName+" "+this.lastName;
   }

   clr:string="";
   colors:string[]=["red","orange","green","brown","yellow"]

}
