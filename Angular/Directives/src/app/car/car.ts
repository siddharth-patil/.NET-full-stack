import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-car',
  imports: [CommonModule],
  templateUrl: './car.html',
  styleUrl: './car.css'
})
export class Car {
    show = true;

    cars:string[] = ['Maruti','Mustang','Volkswagan','Hyundai','Honda'];
}
