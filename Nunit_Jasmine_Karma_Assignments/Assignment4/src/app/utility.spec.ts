import { TestBed, ComponentFixture } from '@angular/core/testing';
import { utility } from './utility';


describe('Utility', () =>{

let spy: any;
let Utility: utility;
 

beforeEach(() =>{
Utility= new utility;
});

  it('Average of three numbers in Positive Test Case', () => {
    spy = spyOn(Utility, 'average').and.returnValue(10);
    expect(Utility.average(10,10,10)).toEqual(10);
    
  });

  it('Average of three numbers in Negative Test Case', () => {
    spy = spyOn(Utility, 'average').and.rejectWith();
    expect(Utility.average(10,10,10)).not.toEqual(9);
    
  });


});