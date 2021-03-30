import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StringLengthComponent } from './string-length.component';

describe('StringLengthComponent', () => {
  let component: StringLengthComponent;
  let fixture: ComponentFixture<StringLengthComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StringLengthComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StringLengthComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  // it('should create', () => {
  //   expect(component).toBeTruthy();
  // });




 // Function to count lenght of string (Positive Testing)
  it('should return length of string (Positive Testing)', ()=>{
    const fixture = TestBed.createComponent(StringLengthComponent);

    const app =fixture.componentInstance;

    expect(app.countLength('Rahul')).toEqual(5);
  });


  // Function to count lenght of string (Negative Testing)
  it('should return length of string (Positive Testing)', ()=>{
    const fixture = TestBed.createComponent(StringLengthComponent);

    const app =fixture.componentInstance;

    expect(app.countLength('Rahul')).not.toEqual(15);
  });
});
