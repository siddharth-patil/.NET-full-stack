import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TemplateDriven } from './template-driven/template-driven';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  imports: [TemplateDriven,CommonModule,FormsModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'forms_angular';
}
