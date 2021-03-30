import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-titlecheck',
  templateUrl: './titlecheck.component.html',
  styleUrls: ['./titlecheck.component.css']
})
export class TitlecheckComponent implements OnInit {
  title= 'Assignment-3';

  constructor() { }

  ngOnInit(): void {
  }

}
