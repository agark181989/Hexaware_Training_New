import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'availability'
})
export class AvailabilityPipe implements PipeTransform {

  transform(quantity:number, emptyMsg:string="Out of stock", instockMsg:string="In Stock"): string {
    if(quantity<=0)
      return emptyMsg;
    else
      return instockMsg;
  }
}
