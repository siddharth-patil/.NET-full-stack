import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, ValidatorFn, Validators } from '@angular/forms';
import { FirstKeyPipe } from '../../shared/pipes/first-key-pipe';
import { Auth } from '../../shared/services/auth';

@Component({
  selector: 'app-registration',
  imports: [ReactiveFormsModule, FormsModule, CommonModule, FirstKeyPipe],
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
  isSubmitted: boolean = false;

  constructor(public formBuilder: FormBuilder, private service:Auth) {
    this.form = this.formBuilder.group({
      fullName: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required,
      Validators.minLength(6),
      Validators.pattern(/(?=.*[^a-zA-Z0-9 ])/)]],
      confirmPassword: ['']
    }, {
      validators: this.passwordMatchValidator
    });
  }

  passwordMatchValidator: ValidatorFn = (control: AbstractControl): null => {

    const password = control.get('password')
    const confirmPassword = control.get('confirmPassword')

    if (password && confirmPassword && password.value != confirmPassword.value) {
      confirmPassword?.setErrors({ passwordMismatch: true })
    }
    else {
      confirmPassword?.setErrors(null);
    }

    return null;
  }

  onSubmit() {
    this.isSubmitted = true;

    if (this.form.valid) {
      this.service.createUser(this.form.value)
      .subscribe({
        next:res=>{
          console.log(res);
        },
        error:err=>console.log('error',err)
      });
    }
  }
}
