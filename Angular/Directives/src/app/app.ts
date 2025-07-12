import { CommonModule} from '@angular/common';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FoodApp } from "./food-app/food-app";
import { Car } from "./car/car";
import { Customer } from './customer/customer';

@Component({
  selector: 'app-root',
  // imports: [CommonModule, FoodApp],
  // imports: [CommonModule,Car],
  imports: [CommonModule,Customer],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  // protected title = 'Directives';

  // show = false;
  // show = true;

  // login = false;
  // login = true;

  // block = 0;

  // updateBlock(){
  //   this.block++;
  // }


  // color:string = 'white';
  // changeColor(color:string){
  //   this.color = color;
  // }

  isActive = false;

  toggle(){
    this.isActive = !this.isActive;
  }

}
