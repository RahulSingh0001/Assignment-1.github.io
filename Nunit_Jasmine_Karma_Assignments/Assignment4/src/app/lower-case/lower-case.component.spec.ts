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

  it('Should used in to convert in lower Case', () =>{
    expect(component.LowerCaseChange()).toEqual('rahul');
  });
  it('Should used in to convert in lower Case', () =>{
    expect(component.LowerCaseChange()).not.toEqual('Rahul');
  });
});
