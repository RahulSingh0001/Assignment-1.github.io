import { AuthService } from './../auth.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-string-length',
  templateUrl: './string-length.component.html',
  styleUrls: ['./string-length.component.css']
})
export class StringLengthComponent implements OnInit {
title="rahul";
  constructor(private auths: AuthService) { }
  stringLenghtFun(){
    return this.auths.lengthofString();
  }

  ngOnInit(): void {
  }

}
