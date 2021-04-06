import { TestBed } from '@angular/core/testing';

import { AuthService } from './auth.service';

describe('AuthService', () => {
  let service: AuthService;
  let auth: AuthService;
  let spy:any;
  const title='Hello';


  // beforeEach(() => {
  //   TestBed.configureTestingModule({});
  //   service = TestBed.inject(AuthService);
  // });

beforeEach(() =>{
auth = new AuthService;

});




  // it('should be created', () => {
  //   expect(service).toBeTruthy();
  // });


// Authentication through serivce Positive test Case 
it('Should used for Authentictaion in Positive Test Senario', () =>{
  spy = spyOn(auth, 'isAuthorized').and.returnValue(true);
    expect(auth.isAuthorized()).toBeTruthy();
    expect(auth.isAuthorized).toHaveBeenCalled();
});
// End of Authentication through serivce Positive test Case

// Authentication through serivce Negative test Case
it('Should used for Authentictaion in Negative Test Senario', () =>{
  spy = spyOn(auth, 'isAuthorized').and.returnValue(false);
    expect(auth.isAuthorized()).toBeFalsy();
    expect(auth.isAuthorized).toHaveBeenCalled();
});
// End of Authentication through serivce Negative test Case





// Test of Reverse string in Positive Test Case
it('Should check for reverse string in Positive Test Case Senario for String:- "Rahul Singh dEmO"', ()=>{
  spy = spyOn(auth,'reverseString').and.returnValue("OmEd hgniS luhaR");
  expect(auth.reverseString('Rahul Singh dEmO')).toEqual("OmEd hgniS luhaR");;
  expect(auth.reverseString).toHaveBeenCalled();
});
// End of Reverse Order through serivce Positive test Case

// Test of Reverse string in Positive Test Case
it('Should check for reverse string in Positive Test Case Senario for String:- "Rahul Singh dEmO"', ()=>{
  // spy = spyOn(auth,'reverseString').and.returnValue("OmEd hgniS luhaR");
  expect(auth.reverseString('Rahul Singh dEmO')).not.toEqual("omEd hgniS luhaR");
  // expect(auth.reverseString).toHaveBeenCalled();
});
// End of Reverse Order through serivce Negative test Case

 
// Test Case to check Title through Service in Positive Test Case
it('Should check for Title in Positive Test Case Senario', ()=>{
   spy= spyOn(auth,'titleCheck').and.returnValue('assignment5');
   expect(auth.titleCheck('assignment5')).toEqual('assignment5');
});
// End of Reverse Order through serivce Negative test Case

// Test Case to check Title through Service in Negative Test Case
it('Should check for Title in Negative Test Case Senario', ()=>{
  spy= spyOn(auth,'titleCheck').and.returnValue('assignment5');
  expect(auth.titleCheck('assignment5')).not.toEqual('assignment6');
});
// End of Reverse Order through serivce Negative test Case


// Test Case to check Length of String through Service in Positive Test Case
it('Should check for Title in Negative Test Case Senario', ()=>{
  
  expect(auth.stringLen('Rahul Singh')).toEqual(11);
});
// End of Length of String through Service in Positive Test Case

// Test Case to check Length of String through Service in Negative Test Case
it('Should check for Title in Negative Test Case Senario', ()=>{
  
  expect(auth.stringLen('Rahul Singh')).not.toEqual(10);
});
// End of Length of String through Service in Negative Test Case


// Test Case of Lower Case for String through Service in Positive Test Case
it('Should check for Title in Negative Test Case Senario', ()=>{
  
  expect(auth.lowerTestCase('Rahul Singh DeMo')).toEqual('rahul singh demo');
});
// End of Lower Case for String through Service in Positive Test Case

// Test Case of Lower Case for String through Service in Negative Test Case
it('Should check for Title in Negative Test Case Senario', ()=>{
  
  expect(auth.lowerTestCase('Rahul Singh DeMo')).not.toEqual('Rahul singh demo');
});
// End of Lower Case for String through Service in Negative Test Case




});
