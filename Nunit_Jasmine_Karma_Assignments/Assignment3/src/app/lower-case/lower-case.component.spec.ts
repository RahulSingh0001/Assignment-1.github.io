import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LowerCaseComponent } from './lower-case.component';

describe('LowerCaseComponent', () => {
  let component: LowerCaseComponent;
  let fixture: ComponentFixture<LowerCaseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LowerCaseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LowerCaseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  // it('should create', () => {
  //   expect(component).toBeTruthy();
  // });



// Test case to convert string into LowerCase for Positive testing//

  it('transforms "ABC DEF" to "abc def" (Positive Test Case)', () => {
    expect(component.transform('ABC DEF')).toEqual('abc def');
  });


  // Test case to convert string into LowerCase for Negative testing//
  it('transforms "ABC DEF" to "abc def" (Negative Test Case)', () => {
    expect(component.transform('ABC DEF')).not.toEqual('Abc Def');
  });


});
