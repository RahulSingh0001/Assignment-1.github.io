import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor() { }
  isAuthorized():boolean{
    return !localStorage.getItem('token');
  };

  reverseString(inputString: string): any{
    return inputString.split('').reverse().join('');
    
  };

  titleCheck(title:string): any{
    return title;

  };


  stringLen(a:string):any{
    if(a=='')
      return null;
    else  
      return a.length;

};
lowerTestCase(lowerCaseString:string): any{
  return lowerCaseString.toLowerCase();
};




  
}
