import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})

export class AuthService {
  isAuthorized():boolean{
    return !!localStorage.getItem('token');
  };
  
  stringLen(a:string):any{
      if(a=='')
        return null;
      else  
        return a.length;

  };

  reverseString(inputString: string): any{
    return inputString.split('').reverse().join('');
    
  }

  titleCheck(title:string): any{
    return title;

  }

  lowerTestCase(lowerCaseString:string): any{
    return lowerCaseString.toLowerCase();
  }



}
