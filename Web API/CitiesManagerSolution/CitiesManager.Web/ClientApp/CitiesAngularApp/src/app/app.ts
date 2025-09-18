import { Component } from '@angular/core';
//import { RouterOutlet } from '@angular/router';
//import { RouterLink } from '../../node_modules/@angular/router/router_module.d';
//import { RouterLinkActive } from '../../node_modules/@angular/router/router_module.d';
import { RouterOutlet, RouterLink, RouterLinkActive } from '@angular/router';


@Component({
  selector: 'app-root',
  imports: [RouterOutlet, RouterLink, RouterLinkActive],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'CitiesAngularApp';
}
