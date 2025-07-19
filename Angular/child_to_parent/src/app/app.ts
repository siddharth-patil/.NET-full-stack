import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Child } from "./child/child";
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [Child,CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'child_to_parent';

  selectedRatingFromChild = 0;

  showRating(rating:number){
    this.selectedRatingFromChild = rating;
  }
}
