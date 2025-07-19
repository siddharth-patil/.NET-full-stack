import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
 
export interface City {
  name: string;
  imageUrl: string;
  places: string[];
}


@Component({
  selector: 'app-city',
  imports: [CommonModule,FormsModule],
  templateUrl: './city1.html',
  styleUrl: './city1.css'
})
export class City_Component implements OnInit{
  
  cities: City[] = [
    {
      name: 'Mumbai',
      imageUrl: './mumbai.jpg', // Placeholder image
      places: ['Gateway of India', 'Marine Drive', 'Elephanta Caves', 'Siddhivinayak Temple']
    },
    {
      name: 'Delhi',
      imageUrl: '.delhi/.jpg', // Placeholder image
      places: ['India Gate', 'Red Fort', 'Qutub Minar', 'Humayun\'s Tomb']
    },
    {
      name: 'Bengaluru',
      imageUrl: './bengluru.jpg', // Placeholder image
      places: ['Lal Bagh Botanical Garden', 'Cubbon Park', 'Bangalore Palace', 'ISKCON Temple']
    },
    {
      name: 'Chennai',
      imageUrl: './chennai.jpg', // Placeholder image
      places: ['Marina Beach', 'Kapaleeshwarar Temple', 'Fort St. George', 'Government Museum']
    }
  ];

  selectedCityName: string = '';
  currentCity: City | null = null; 

  ngOnInit(): void {
    if (this.cities.length > 0) {
      this.selectedCityName = this.cities[0].name;
      this.displayCityInfo();
    }
  }

  displayCityInfo(): void {
    this.currentCity = this.cities.find(city => city.name === this.selectedCityName) || null;
  }
}