import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-child',
  imports: [CommonModule],
  templateUrl: './child.html',
  styleUrl: './child.css'
})
export class Child {

  stars = [1,2,3,4,5];
  selectedRating = 0;

  @Output() ratingSelected = new EventEmitter<number>();

  chooseRating(rating:number){
    this.selectedRating = rating;
    this.ratingSelected.emit(rating);
  }

}
