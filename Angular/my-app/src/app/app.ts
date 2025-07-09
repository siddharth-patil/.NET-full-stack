import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Login } from "./login/login";
import { Signup } from "./signup/signup";

@Component({
  selector: 'app-root',
  imports: [Login, Signup],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  // protected title = 'my-app';
  // title1 = 'Angular first app';
  // name = '.Net fullstack';
  // x=12;
  // y=23;
  // text1= "brother";
  // text2= "bhava";
  // p=true;
  // q=true;
 count:number = 0;
  handleCounter(val:string){
    if(val === 'minus'){
      if(this.count>0){
        this.count = this.count-1
      }
    }else if(val === 'plus'){
        this.count = this.count+1;
      }else if(val===''){
        this.count=0;
      }
  }

}
