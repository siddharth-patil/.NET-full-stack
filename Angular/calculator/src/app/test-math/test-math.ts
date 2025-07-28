import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, ReactiveFormsModule } from '@angular/forms';
import { MathService } from '../services/math-service';

@Component({
  selector: 'app-test-math',
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './test-math.html',
  styleUrl: './test-math.css'
})
export class TestMath {
  result: number | string = '';
  calculatorForm: any;

  // constructor(mathService:MathService){}

  constructor(private fb: FormBuilder, private mathService: MathService) {
    this.calculatorForm = this.fb.group({
      number1: [0],
      number2: [0],
      operation: ['+']
    });
  }

  clearAll() {
    this.calculatorForm.reset({ number1: 0, number2: 0 });
    this.result = '';
  }

  calculate(operation:string) {
    const { number1, number2 } = this.calculatorForm.value;
    switch (operation) {
      case '+':
        this.result = this.mathService.add(number1,number2);
        break;
      case '-':
        this.result = this.mathService.subtract(number1,number2);
        break;
      case '*':
        this.result = this.mathService.multiply(number1,number2);
        break;
      case '/':
        this.result = this.mathService.divide(number1,number2);
        break;
    }
  }
}
