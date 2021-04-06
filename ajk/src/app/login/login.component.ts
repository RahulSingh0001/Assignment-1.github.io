import { AuthService } from './../auth.service';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  
  constructor(private auth: AuthService) { }
  needsLogin(){
    return !this.auth.isAuthenticated();
  }

  ngOnInit(): void {
  }

}