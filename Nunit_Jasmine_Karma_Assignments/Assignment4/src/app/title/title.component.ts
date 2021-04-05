import { AuthService } from './../auth.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-title',
  templateUrl: './title.component.html',
  styleUrls: ['./title.component.css']
})
export class TitleComponent {

  constructor(private authors:AuthService) { }
  titleCase(){
    return this.authors.titleCheck('Services and Classes');
  }

  
}
