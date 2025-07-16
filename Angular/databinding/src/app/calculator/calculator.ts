import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-calculator',
  imports: [FormsModule,CommonModule],
  templateUrl: './calculator.html',
  styleUrl: './calculator.css'
})
export class Calculator {
  txt1:string = "";
  txt2:string = "";
  output:string="";
  add(){
    this.output = String(Number(this.txt1)+Number(this.txt2));
  }

  subtract(){
    this.output = String(Number(this.txt1)-Number(this.txt2));
  }

  divide(){
    this.output = String(Number(this.txt1)/Number(this.txt2));
  }

  multiply(){
    this.output = String(Number(this.txt1)*Number(this.txt2));
  }
}
