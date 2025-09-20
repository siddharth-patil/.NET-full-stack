import { Component } from '@angular/core';
import { City } from '../models/city';
import { CitiesService } from '../services/citiesService';
import { CommonModule } from '@angular/common';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-cities',
  imports: [CommonModule],
  templateUrl: './cities.html',
  styleUrl: './cities.css',
})
export class Cities {
  cities: City[] = [];
  postCityForm : FormGroup;

  constructor(private citiesService: CitiesService) {
    this.postCityForm = new FormGroup({
      cityName:new FormControl(null,[Validators.required])
    })
  }

  loadCities(){
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

  ngOnInit() {
    this.loadCities();
  }

  get postCity_CityNameControl(): any{
    return this.postCityForm.controls['cityName'];
  }

  postCitySubmitted(){
    
  }
}
