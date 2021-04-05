import { AuthService } from '../auth.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-mock-reverse',
  templateUrl: './mock-reverse.component.html',
  styleUrls: ['./mock-reverse.component.css']
})
export class MockReverseComponent{

  constructor(private author: AuthService) {}
 reversing(){
   return this.author.reverseString('Rahul Singh');
 }
  
}
