import { Component } from '@angular/core';
import { City } from '../models/city';
import { CitiesService } from '../services/citiesService';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-cities',
  imports: [CommonModule],
  templateUrl: './cities.html',
  styleUrl: './cities.css',
})
export class Cities {
  cities: City[] = [];

  constructor(private citiesService: CitiesService) {}

  ngOnInit() {
    this.citiesService.getCities().subscribe({
      next: (response: City[]) => {
        this.cities = response;
      },
      error: (error: any) => {
        console.log(error);
      },
      complete: () => {},
    });
  }
}
