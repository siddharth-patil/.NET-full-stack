import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactive-form',
  imports: [FormsModule,CommonModule,ReactiveFormsModule],
  templateUrl: './reactive-form.html',
  styleUrl: './reactive-form.css'
})
export class ReactiveForm {
  onSubmit(){
    console.log(this.profileForm.value);
  }

  setValues(){
    this.profileForm.setValue({
      name:'sid',
      password:'sid@123',
      email:'sid@gmail.com'
    });
  }

  profileForm = new FormGroup({
    name:new FormControl('',[Validators.required,Validators.minLength(2)]),
    password:new FormControl('',[Validators.required, Validators.minLength(4),Validators.maxLength(12)]),
    email:new FormControl('',[Validators.required, Validators.email])
  });
}
