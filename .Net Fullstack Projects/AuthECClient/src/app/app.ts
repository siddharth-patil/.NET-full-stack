import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { User } from "./user/user";

@Component({
  selector: 'app-root',
  imports: [User,RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'AuthECClient';
}
