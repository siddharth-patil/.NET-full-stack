import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Child } from '../child/child';

@Component({
  selector: 'app-parent',
  imports: [FormsModule,CommonModule,Child],
  templateUrl: './parent.html',
  styleUrl: './parent.css'
})
export class Parent {

  users = [
    {name:'sid', email:'sid@gmail.com'},
    {name:'ram', email:'ram@gmail.com'},
    {name:'sita', email:'sita@gmail.com'}
  ];

  selectedUser = this.users[0];
  selectUser(user:any){
    this.selectedUser = user;
  }

}
