import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-user',
  imports: [],
  templateUrl: './user.html',
  styleUrl: './user.css'
})
export class User {

  @Input() counter = 0;
  name='sam';

  // constructor(){
  //   console.log("constructor called");
  //   this.name = 'tom';
  // }

  // ngOnInit(){
  //   console.log('ngOnInit() called');
  //   this.name='jerry';
  // }

  ngOnDestroy(){
    console.log(`ngOnDestroy() called`);
  }

  ngOnChanges(){
    console.log('ngOnChanges() called');
  }
}
