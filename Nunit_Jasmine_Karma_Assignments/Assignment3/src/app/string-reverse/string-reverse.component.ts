import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-string-reverse',
  templateUrl: './string-reverse.component.html',
  styleUrls: ['./string-reverse.component.css']
})
export class StringReverseComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }


  //Function to reverse the order of string
   reverseString(str:string) {
    return str.split('').reverse().join('');
  }


}
