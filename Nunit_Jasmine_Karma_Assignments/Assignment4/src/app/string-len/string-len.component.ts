import { AuthService } from './../auth.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-string-len',
  templateUrl: './string-len.component.html',
  styleUrls: ['./string-len.component.css']
})
export class StringLenComponent {

  constructor(public autho: AuthService) {

   }
   strnglength(){
     return this.autho.stringLen('rahuls');
   }

  

}
