import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'currencyConvertor'
})
export class CurrencyConvertorPipe implements PipeTransform {

  transform(value: number, ...args: number[]): number {

    console.log(args);
     if(args.length>0){
        let [data] = args;
        return data*value;
     }
     else{
      return value*85;
     }

  }

}
