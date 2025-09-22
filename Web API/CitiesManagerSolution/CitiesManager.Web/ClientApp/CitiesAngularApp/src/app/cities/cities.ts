import { Component } from '@angular/core';
import { City } from '../models/city';
import { CitiesService } from '../services/citiesService';
import { CommonModule } from '@angular/common';
import {
  FormArray,
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';

@Component({
  selector: 'app-cities',
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './cities.html',
  styleUrl: './cities.css',
})
export class Cities {
  cities: City[] = [];
  postCityForm: FormGroup;
  isPostCityFormSubmitted: boolean = false;
  putCityForm: FormGroup;
  editCityID: string | null = null;

  constructor(private citiesService: CitiesService) {
    this.postCityForm = new FormGroup({
      cityName: new FormControl(null, [Validators.required]),
    });

    this.putCityForm = new FormGroup({
      cities: new FormArray([]),
    });
  }

  get putCityFormArray(): FormArray {
    return this.putCityForm.get('cities') as FormArray;
  }

  loadCities() {
    this.citiesService.getCities().subscribe({
      next: (response: City[]) => {
        this.cities = response;

        this.cities.forEach((city) => {
          this.putCityFormArray.push(
            new FormGroup({
              cityID: new FormControl(city.cityID, [Validators.required]),
              cityName: new FormControl({value:city.cityName, disabled:true}, [Validators.required]),
            })
          );
        });
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

  get postCity_CityNameControl(): any {
    return this.postCityForm.controls['cityName'];
  }

  public postCitySubmitted() {
    this.isPostCityFormSubmitted = true;

    console.log(this.postCityForm.value);

    this.citiesService.postCities(this.postCityForm.value).subscribe({
      next: (response: City) => {
        console.log(response);

        // this.loadCities();
        this.cities.push(new City(response.cityID, response.cityName));
        this.postCityForm.reset();
        this.isPostCityFormSubmitted = false;
      },
      error: (error: any) => {
        console.log(error);
      },
      complete: () => {},
    });
  }

  
    editClicked(city:City):void{
      this.editCityID = `${city.cityID}`;
    }

    updateClicked(i:number):void{

    }

}
