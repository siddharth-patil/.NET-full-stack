import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  imports: [],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home {

  aboutRRClub:string = 'About Royal Roders Club';

  imgpath:string = 'RRClub.png';

  description:string=`Where the Road Meets Brotherhood.

At Royal Rider Club, we believe riding is't just a hobby — it's a lifestyle. We're a passionate community of motorcycle enthusiasts who live for the thrill of the open road, the roar of engines, and the bond that forms between riders.

Whether you're a seasoned biker or just starting your journey, Royal Rider Club is your home. We organize long-distance rides, weekend getaways, maintenance workshops, and community meetups — all centered around our shared love for two wheels.`;
}
