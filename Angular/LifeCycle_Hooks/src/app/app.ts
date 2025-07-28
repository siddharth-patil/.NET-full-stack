import { afterEveryRender, afterNextRender, Component, Input, ViewChild } from '@angular/core';
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

  @ViewChild('user') User:any;
  counter=0;

  constructor(){
    afterEveryRender(()=>{
      console.log('afterEveryRender() called',this.User.counter);
    })

    afterNextRender(()=>{
      console.log('afterNextRender() called',this.User.counter);
    })
  }

  updateCounter(){
    this.counter++;
  }

}
