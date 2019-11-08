import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'reverse'
})
export class ReversePipe implements PipeTransform {

  transform(str: string): string {
    if(!str)
        return "";
    else{
      let result = "";
      for(let i = 0;i<str.length;i++){
        result=str.charAt(i)+result;
      }
      return result;
    }
  }

}
