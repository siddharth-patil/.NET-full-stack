import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-city',
  imports: [CommonModule,FormsModule],
  templateUrl: './city.html',
  styleUrl: './city.css'
})
export class City {

  city:string='select city';
  
  cityNames:string[] = ['Mumbai','Varanasi','Pune','Jodhpur'];

  ht:number = 400; 
  wd:number = 400; 
  imgUrl:string="";

  Index:number = -1;
  selectedValue:string='';

  getCity(event: Event){
    // const cityName = document.getElementById('#cityValue') as HTMLSelectElement;
    // console.log(cityName.options[cityName.selectedIndex].text);

    const cityName = event.target as HTMLSelectElement;

    this.Index = cityName.selectedIndex;
    this.selectedValue = cityName.value;

    // console.log(this.Index);
    // console.log(this.selectedValue);
    
  }

  showCity(){
    this.imgUrl = `city${this.Index}.jpg`;
  }
  
  
}
