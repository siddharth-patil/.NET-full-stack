import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  imports: [CommonModule,ReactiveFormsModule],
  templateUrl: './login.html',
  styleUrl: './login.css'
})
export class Login {
  from:FormGroup | undefined;
  

  constructor(public formBuilder:FormBuilder){
    
  }

  ngOnInit(){
      this.from = this.formBuilder.group({
    
  })
  }


}
