import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UpperCaseComponent } from './upper-case.component';

describe('UpperCaseComponent', () => {
  let component: UpperCaseComponent;
  let fixture: ComponentFixture<UpperCaseComponent>;
  

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpperCaseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UpperCaseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });
 




  // it('should create', () => {
  //   expect(component).toBeTruthy();
  // });




  // Test case to convert string into UpperCase for positive testing//
  it('transforms "abc def" to "Abc Def" (Positive Test Case)', () => {
    expect(component.transform('abc def')).toEqual('ABC DEF');
  });
 

  // Test case to convert string into UpperCase for negative testing//
  it('transforms "abc def" to "Abc Def" (Negative Test Case)', () => {
    expect(component.transform('abc def')).not.toEqual('Abc def');
  });







});
