import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  title = 'Hello From Component';
  titles = 'GeeksforGeeks';
  fullName: string = "Hello Demo";
  
    currentItem = 'Television';
    ColumnSpan: number=2;
    pageHeader: string = 'Student Details';
    FirstName: string = 'Anurag';
    LastName: string = 'Mohanty';
    Branch: string = 'CSE';
    Mobile: number = 9876543210;
    Gender: string = 'Male';
    Age: number = 22;


    items = ['item1', 'item2', 'item3', 'item4'];

  addItem(newItem: string) {
    this.items.push(newItem);
  }

  
  isUnchanged = true;

  text = ''; 
onKeyUp(x:any) { 

	// Appending the updated value 
	// to the variable 
	this.text += x.target.value + ' | '; 
} 





}





	 



