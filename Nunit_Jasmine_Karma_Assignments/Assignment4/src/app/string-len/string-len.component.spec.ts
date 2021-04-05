import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StringLenComponent } from './string-len.component';

describe('StringLenComponent', () => {
  let component: StringLenComponent;
  let fixture: ComponentFixture<StringLenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StringLenComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StringLenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  // it('should create', () => {
  //   expect(component).toBeTruthy();
  // });

  it('Should be length true ', () => {
   expect(component.strnglength()).toEqual(6);
  });

  it('Should be length true ', () => {
    expect(component.strnglength()).not.toEqual(5);
   });

});
