import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TestMath } from "./test-math/test-math";

@Component({
  selector: 'app-root',
  imports: [TestMath],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'calculator';
}
