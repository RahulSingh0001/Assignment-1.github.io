import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TitleCaseComponent } from './title-case.component';

describe('TitleCaseComponent', () => {
  let component: TitleCaseComponent;
  let fixture: ComponentFixture<TitleCaseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TitleCaseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TitleCaseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  // it('should create', () => {
  //   expect(component).toBeTruthy();
  // });


  // Test Case to Convert string into Title Case Positive Testing
  it('should convert the string into title case',()=>{
    const fixture = TestBed.createComponent(TitleCaseComponent);

    const app =fixture.componentInstance;

    expect(app.transform('rahul singh')).toEqual('Rahul Singh');
  });


// Test Case to Convert string into Title Case Negative Testing
  it('should convert the string into title case',()=>{
    const fixture = TestBed.createComponent(TitleCaseComponent);

    const app =fixture.componentInstance;

    expect(app.transform('rahul singh')).not.toEqual('RAHUL SINGH');
  });
});
