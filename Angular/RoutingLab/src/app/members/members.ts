import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-members',
  imports: [CommonModule],
  templateUrl: './members.html',
  styleUrl: './members.css'
})
export class Members {

  members:any[] = [
    {
      firstName:'Siddharth',
      lastName:'Patil',
      email:'sid@gmail.com',
      birthdate:'27-02-2000',
      contact:'9922717103',
      city:'Pune',
      photopath:'profilePhoto.png'
    },
    {
      firstName:'Siddharth',
      lastName:'Patil',
      email:'sid@gmail.com',
      birthdate:'27-02-2000',
      contact:'9922717103',
      city:'Pune',
      photopath:'profilePhoto.png'
    },
    {
      firstName:'Siddharth',
      lastName:'Patil',
      email:'sid@gmail.com',
      birthdate:'27-02-2000',
      contact:'9922717103',
      city:'Pune',
      photopath:'profilePhoto.png'
    },
    {
      firstName:'Siddharth',
      lastName:'Patil',
      email:'sid@gmail.com',
      birthdate:'27-02-2000',
      contact:'9922717103',
      city:'Pune',
      photopath:'profilePhoto.png'
    }
  ];

}
