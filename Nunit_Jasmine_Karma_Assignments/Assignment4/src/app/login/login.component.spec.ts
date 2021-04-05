import { AuthService } from './../auth.service';
import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LoginComponent } from './login.component';

describe('LoginComponent', () => {
  let component: LoginComponent;
  let fixture: ComponentFixture<LoginComponent>;
  let service: AuthService;

  

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LoginComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  beforeEach(()=>{
    service = new AuthService();
    component= new LoginComponent(service); 
      });
  
        
  afterEach(()=>{

  localStorage.removeItem('token');
  // service=null;
  // component=null;
      });

it('needsLogin returns true when the user has not been authenticated', () => {
   expect(component.needsLogin()).toBeTruthy();
});

it('needsLogin returns false when the user has been authenticated', () => {
     localStorage.setItem('token', '12345');
    expect(component.needsLogin()).toBeFalsy();
});
});
