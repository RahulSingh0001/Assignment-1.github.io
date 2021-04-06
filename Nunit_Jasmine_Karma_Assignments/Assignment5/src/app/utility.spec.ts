import { TestBed, ComponentFixture } from '@angular/core/testing';
import { utility } from './utility';


describe('Utility', () =>{

let spy: any;
let Utility: utility;
 

beforeEach(() =>{
Utility= new utility;
});


// Test Case to check Average Function in Positive Test Case Senario
  it('Average of three numbers in Positive Test Case', () => {
    
    expect(Utility.average(10,10,10)).toEqual(10);
    
  });

  // End of check Average Function in Positive Test Case Senario



  //  Test Case to check Average Function with Spy in Positive Test Case Senario
  it('Average of three numbers in Positive Test Case', () => {
    spy = spyOn(Utility, 'average').and.returnValue(10);
    expect(Utility.average(10,10,10)).toEqual(10);
    expect(Utility.average).toHaveBeenCalled(); // checks whether fuction 'average()' has been called or not;
    
  });
  // End of check Average Function in Positive Test Case Senario



  // Test Case to check Average Function  in Negative Test Case Senario
  it('Average of three numbers in Negative Test Case', () => {
    // spy = spyOn(Utility, 'average').and.rejectWith();
    expect(Utility.average(10,10,10)).not.toEqual(9);
    
  });
  // End of check Average Function  in Negative Test Case Senario


});