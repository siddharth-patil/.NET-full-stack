import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-city',
  imports: [CommonModule, FormsModule],
  templateUrl: './city.html',
  styleUrl: './city.css'
})
export class City {

  city: string = 'select city';

  cityNames: string[] = ['Mumbai', 'Varanasi', 'Pune', 'Jodhpur'];

  // Mumbai: string[] = ['Juhu beach', 'The Gateway of India', 'Sanjay Gandhi National Park'];
  // Varanasi: string[] = ['Kashi Vishwanath Temple', 'Ramnagar Fort', 'Vindham Waterfalls'];
  // Pune: string[] = ['Shaniwar Wada', 'Sinhagad Fort', 'Aga Khan Palace'];
  // Jodhpur: string[] = ['Meharanghar Fort', 'Kalyana Lake', 'Mandore Garden'];

  touristSpots:any ={
    'Mumbai' : ['Juhu beach', 'The Gateway of India', 'Sanjay Gandhi National Park'],
    'Varanasi' : ['Kashi Vishwanath Temple', 'Ramnagar Fort', 'Vindham Waterfalls'],
    'Pune' : ['Shaniwar Wada', 'Sinhagad Fort', 'Aga Khan Palace'],
    'Jodhpur' : ['Meharanghar Fort', 'Kalyana Lake', 'Mandore Garden'],
  };

  ht: number = 400;
  wd: number = 400;
  imgUrl: string = "";

  Index: number = -1;
  selectedValue: string = '';
  selectedCity: string[] = [];


  getCity(event: Event) {

    const cityName = event.target as HTMLSelectElement;

    this.Index = cityName.selectedIndex;
    this.selectedValue = cityName.value;

  }

  // showImage = false;

  showCity() {

    this.imgUrl = `city${this.Index}.jpg`;

    // this.showImage = !this.showImage;
    // if (this.selectedValue === 'Mumbai')
    //   this.selectedCity = this.Mumbai;
    // else if (this.selectedValue === 'Varanasi')
    //   this.selectedCity = this.Varanasi;
    // else if (this.selectedValue === 'Pune')
    //   this.selectedCity = this.Pune;
    // else if (this.selectedValue === 'Jodhpur')
    //   this.selectedCity = this.Jodhpur;
  }


}
