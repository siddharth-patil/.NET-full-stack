import { Component, Input } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { User } from "./user/user";
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [User,CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'LifeCycle_Hooks';

  counter=0;

  updateCounter(){
    this.counter++;
  }

}
