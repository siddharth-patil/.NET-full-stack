import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-template-driven',
  imports: [CommonModule,FormsModule],
  templateUrl: './template-driven.html',
  styleUrl: './template-driven.css'
})
export class TemplateDriven {

  userDetails:any;

  addDetails(formData:any){
    this.userDetails = formData;

    console.log('Submitted data:', this.userDetails);
  }

}
