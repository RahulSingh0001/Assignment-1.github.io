import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TitlecheckComponent } from './titlecheck.component';

describe('TitlecheckComponent', () => {
  let component: TitlecheckComponent;
  let fixture: ComponentFixture<TitlecheckComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TitlecheckComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TitlecheckComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  // it('should create', () => {
  //   expect(component).toBeTruthy();
  // });

// Test case to check title of component for Positive testing//
it(`should have as title 'Assignment-3("for Positive testing")'`, () => {
  const fixture = TestBed.createComponent(TitlecheckComponent);
  const app = fixture.debugElement.componentInstance;
  expect(app.title).toEqual('Assignment-3');
});


// Test case to check title of component  for Negative Testing//
it(`should have as title 'Assignment-3("for Negative testing")'`, () => {
  const fixture = TestBed.createComponent(TitlecheckComponent);
  const app = fixture.debugElement.componentInstance;
  expect(app.title).not.toEqual('Assignment-4');
});




});
