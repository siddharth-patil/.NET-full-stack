import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TemplateDriven } from './template-driven/template-driven';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ReactiveForm } from "./reactive-form/reactive-form";

@Component({
  selector: 'app-root',
  // imports: [TemplateDriven, CommonModule, FormsModule, ReactiveForm],
  imports: [CommonModule, FormsModule, ReactiveForm],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'forms_angular';
}
