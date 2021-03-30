import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StringReverseComponent } from './string-reverse.component';

describe('StringReverseComponent', () => {
  let component: StringReverseComponent;
  let fixture: ComponentFixture<StringReverseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StringReverseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StringReverseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  // it('should create', () => {
  //   expect(component).toBeTruthy();
  // });




  //Function to reverse the order of string (Positive Testing)
  it('should return length of string (Positive Testing', ()=>{
    const fixture = TestBed.createComponent(StringReverseComponent);

    const app =fixture.componentInstance;

    expect(app.reverseString('Rahul singh')).toEqual('hgnis luhaR');
  });




  
  //Function to reverse the order of string (Negative Testing)
  it('should return length of string (Positive Testing', ()=>{
    const fixture = TestBed.createComponent(StringReverseComponent);

    const app =fixture.componentInstance;

    expect(app.reverseString('Rahul Singh')).not.toEqual('Singh Rahul');
  })
});
