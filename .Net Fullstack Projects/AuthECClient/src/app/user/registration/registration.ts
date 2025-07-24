import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-registration',
  imports: [ReactiveFormsModule, FormsModule],
  templateUrl: './registration.html',
  styleUrl: './registration.css'
})
export class Registration {
  // constructor(public formBuilder:FormBuilder){}

  // form = this.formBuilder.group({
  //   fullName:[''],    
  //   email:[''],    
  //   password:[''],    
  //   confirmPassword:[''] 
  // });

  form: FormGroup;

  constructor(public formBuilder: FormBuilder) {
    this.form = this.formBuilder.group({
      fullName: [''],
      email: [''],
      password: [''],
      confirmPassword: ['']
    });
  }

  onSubmit() {
    console.log(this.form.value);
  }
}
