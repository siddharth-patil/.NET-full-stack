import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  imports: [CommonModule,ReactiveFormsModule],
  templateUrl: './login.html',
  styleUrl: './login.css'
})
export class Login {
  from:FormGroup | any;
  

  constructor(public formBuilder:FormBuilder){
    
  }

  ngOnInit(){
      this.from = this.formBuilder.group({
    email:['',Validators.required],
    password:['',Validators.required]
  })
  }


}
