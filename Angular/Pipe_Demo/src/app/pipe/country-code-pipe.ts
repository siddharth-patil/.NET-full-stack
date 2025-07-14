import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'countryCode'
})
export class CountryCodePipe implements PipeTransform {

  transform(value: string): string {
    if (value == 'India')
      return 'IND';
    else if (value == 'Germany')
      return 'GER';
    else if (value == 'Italy')
      return 'ITLY';
    else if (value == 'Australia')
      return 'AUS';
    else
      return 'Unknown';

  }

}
