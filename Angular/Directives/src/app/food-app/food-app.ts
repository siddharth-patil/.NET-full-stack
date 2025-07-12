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

  show:boolean = true;
  headingColor:string="MAROON";

  // array of dishes

  foodArr:FoodDish[] = [
    new FoodDish("paneerParatha.jpg","Paneer Paratha","veg","Punjabi",120),
    new FoodDish("alooParatha.avif","Aloo Paratha","veg","Gujarathi",100),
    new FoodDish("biryani.jfif","Biryani","nonveg","Haidrabadi",220),
    new FoodDish("misal.webp","Kolhapuri Misal","veg","Maharashtrian",99),
  ]
}
