import { Component } from '@angular/core';
import { FoodDish } from './foodDish';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-fooditem',
  imports: [CommonModule],
  templateUrl: './food-app.html',
  styleUrl: './food-app.css'
})
export class FoodApp {

  show:boolean = false;
  headingColor:string="MAROON";

  // array of dishes

  foodArr:FoodDish[] = [
    new FoodDish("","Paneer Paratha","veg","Punjabi",120),
    new FoodDish("","Aloo Paratha","veg","Gujarathi",100),
    new FoodDish("","Biryani","nonveg","Haidrabadi",120),
    new FoodDish("","Kolhapuri Misal","veg","Maharashtrian",120),
  ]
}
