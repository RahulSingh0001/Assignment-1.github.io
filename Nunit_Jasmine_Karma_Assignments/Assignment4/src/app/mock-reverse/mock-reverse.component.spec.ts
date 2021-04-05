import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MockReverseComponent } from './mock-reverse.component';

describe('MockReverseComponent', () => {
  let component: MockReverseComponent;
  let fixture: ComponentFixture<MockReverseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MockReverseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MockReverseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  // it('should create', () => {
  //   expect(component).toBeTruthy();
  // });

  it('Should used to reverse the string', () => {
    const app =fixture.componentInstance;
    expect(app.reversing()).toEqual('hgniS luhaR');

  });
  it('Should used to reverse the string', () => {
    const app =fixture.componentInstance;
    expect(app.reversing()).not.toEqual('hgnis luhaR');

  });

  
});
