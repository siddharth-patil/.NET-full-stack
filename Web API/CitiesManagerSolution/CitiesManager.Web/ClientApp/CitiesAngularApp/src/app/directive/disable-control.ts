import { Directive, Input } from '@angular/core';
import { FormControl, NgControl } from '@angular/forms';

@Directive({
  selector: '[disableControl]'
})
export class DisableControl {

  constructor(private ngControl:NgControl) {

   }
   
   @Input() set disableControl(condition:boolean){
    var control = this.ngControl.control as FormControl;

    if (control){
      if (condition){
        control.disable();
      }
      else
        control.enable();
    }
   }

}
