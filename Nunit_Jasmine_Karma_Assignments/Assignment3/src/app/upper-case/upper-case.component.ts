import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-upper-case',
  templateUrl: './upper-case.component.html',
  styleUrls: ['./upper-case.component.css']
})

export class UpperCaseComponent implements OnInit {

  

  constructor() { }

  ngOnInit(): void {}
  

  //Function to Convert Lower Case into Upper Case//
  transform(value: string) {
    return value.toLowerCase().replace(/[a-z]/g, function(m) {
      return m.toUpperCase();
      
    });
    
}
}
