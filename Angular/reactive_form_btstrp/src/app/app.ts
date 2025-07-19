import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormControl, FormControlDirective, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [FormsModule,CommonModule,ReactiveFormsModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'reactive_form_btstrp';

  onSubmit(){
    console.log(this.signInForm.value);
  }

  signInForm = new FormGroup({
    email: new FormControl('',[Validators.required, Validators.email]),
    password: new FormControl('',[Validators.required, Validators.minLength(5)]),
    address: new FormControl('',[Validators.required]),
    address2: new FormControl(''),
    city: new FormControl('',[Validators.required, Validators.minLength(2)]),
    state: new FormControl('',[Validators.required]),
    zip: new FormControl('',[Validators.required, Validators.minLength(6), Validators.maxLength(6)]),
    checkbox: new FormControl('false',[Validators.requiredTrue])
  });
}
