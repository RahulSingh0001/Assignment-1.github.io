import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-string-length',
  templateUrl: './string-length.component.html',
  styleUrls: ['./string-length.component.css']
})
export class StringLengthComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  // Function to count lenght of string
  countLength(inputString : string){
    if(inputString=='')
      return null;
    else  
      return inputString.length;
  }

}
