import { CommonModule} from '@angular/common';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [CommonModule],
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


  color:string = 'white';
  changeColor(color:string){
    this.color = color;
  }

}
