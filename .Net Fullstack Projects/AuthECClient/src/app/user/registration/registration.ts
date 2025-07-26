import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, ValidatorFn, Validators } from '@angular/forms';
import { FirstKeyPipe } from '../../shared/pipes/first-key-pipe';
import { Auth } from '../../shared/services/auth';
import { ToastrService } from 'ngx-toastr';

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

  constructor(public formBuilder: FormBuilder, private service: Auth, private toastr: ToastrService) {
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
          next: (res: any) => {
            if (res.succeeded) {
              this.form.reset();
              this.isSubmitted = false;
              this.toastr.success('New user created!', 'Registration Successful');
            }
            else
              console.log('response', res);
              
          },
          error: err => {
            console.log('response', err);
            if (err.error.errors) {
              err.error.errors.forEach((element: any) => {
                switch (element.code) {
                  case 'DuplicateUserName':
                    this.toastr.error('Email is already taken.', 'Registration Failed')
                    break;
                  case 'DuplicateEmail':
                    this.toastr.error('Email is already taken.', 'Registration Failed')
                    break;
                  default:
                    this.toastr.error('Contact the developer!', 'Registration Failed');
                    console.log(element);
                    break;
                }
              });
            }
            else {
              console.log('err', err);
            }
          }
        });
    }
  }
}
