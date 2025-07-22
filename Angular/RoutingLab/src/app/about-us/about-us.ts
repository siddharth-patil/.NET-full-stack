import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-about-us',
  imports: [CommonModule],
  templateUrl: './about-us.html',
  styleUrl: './about-us.css'
})
export class AboutUs {
  mission = `To build a passionate and inclusive community of motorcycle enthusiasts who live for the thrill of the ride, the bond of brotherhood, and the joy of exploration.`;

  vision = `To be the most iconic and respected rider club, known for its adventure rides, discipline, and commitment to promoting safe and enjoyable motorcycling.`;

  values = [
    'Brotherhood & Camaraderie',
    'Safety & Responsibility',
    'Adventure & Exploration',
    'Discipline & Respect',
    'Community Contribution'
  ];

  history = `
    Founded in 2020 by a group of spirited bikers in Mumbai, the Royal Rider Club began as a small weekend riding group. Over the years, it evolved into a diverse family of riders from all walks of life, united by their love for motorcycles. Whether it's a short city ride or a cross-country expedition, RRClub believes every journey creates stories worth remembering.`;

}
