import { AuthService } from './../auth.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-lower-case',
  templateUrl: './lower-case.component.html',
  styleUrls: ['./lower-case.component.css']
})
export class LowerCaseComponent  {

  constructor(private authorss: AuthService) { }

  LowerCaseChange(){
    return this.authorss.lowerTestCase('RAHUL');
  }
 
}
