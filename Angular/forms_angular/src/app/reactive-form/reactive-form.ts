import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';

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
    
  }

  profileForm = new FormGroup({
    name:new FormGroup('xyz'),
    password:new FormGroup('x@123'),
    email:new FormGroup('xyz@gmail.com')
  });
}
