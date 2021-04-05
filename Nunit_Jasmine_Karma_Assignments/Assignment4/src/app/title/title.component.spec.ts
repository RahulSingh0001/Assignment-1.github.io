import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TitleComponent } from './title.component';

describe('TitleComponent', () => {
  let component: TitleComponent;
  let fixture: ComponentFixture<TitleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TitleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TitleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  // it('should create', () => {
  //   expect(component).toBeTruthy();
  // });

it('Should be used to Check the title ', () =>{
 expect(component.titleCase()).toEqual('Services and Classes')
});

it('Should be used to Check the title ', () =>{
  expect(component.titleCase()).not.toEqual('Service and Classes')
 });



});
