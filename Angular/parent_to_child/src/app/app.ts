import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Parent } from "./parent/parent";

@Component({
  selector: 'app-root',
  imports: [Parent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'parent_to_child';
}
