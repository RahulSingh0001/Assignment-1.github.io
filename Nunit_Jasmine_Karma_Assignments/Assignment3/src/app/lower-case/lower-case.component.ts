import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-lower-case',
  templateUrl: './lower-case.component.html',
  styleUrls: ['./lower-case.component.css']
})
export class LowerCaseComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

   //Function to Convert Upper Case into Lower Case//
  transform(value: string) {
    return value.toUpperCase().replace(/[A-Z]/g, function(m) {
      return m.toLowerCase();
    });

}
}
