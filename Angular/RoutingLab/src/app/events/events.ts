import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-events',
  imports: [CommonModule],
  templateUrl: './events.html',
  styleUrl: './events.css'
})
export class Events {
  event = {
    title: 'Royal Rider Mega Rally 2025',
    date: '2025-09-15T10:00:00',
    location: 'Marine Drive, Mumbai',
    description: 'Join us for a thrilling ride through the coast! Meet passionate riders, showcase your bikes, and ride the roads like royalty.',
    speakers: [
      {
        name: 'Rider Aniket Singh',
        bio: 'Professional stunt rider and moto vlogger.',
        image: 'favicon.ico'
      },
      {
        name: 'Priya Sinha',
        bio: 'Adventure traveler and biker influencer.',
        image: 'favicon.ico'
      }
    ]
  };

  getTimeLeft(): string {
    const now = new Date().getTime();
    const eventTime = new Date(this.event.date).getTime();
    const diff = eventTime - now;
    if (diff <= 0) return 'Event Started';
    const days = Math.floor(diff / (1000 * 60 * 60 * 24));
    const hours = Math.floor((diff / (1000 * 60 * 60)) % 24);
    const minutes = Math.floor((diff / (1000 * 60)) % 60);
    return `${days}d ${hours}h ${minutes}m`;
  }
}
