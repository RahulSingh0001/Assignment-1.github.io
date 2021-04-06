import { HttpAsyncService } from './http-async.service';
import { fakeAsync, TestBed, tick } from '@angular/core/testing';

import { AsyncMethodService } from './async-method.service';

describe('AsyncMethodService', () => {
  
let service: AsyncMethodService;
beforeEach(() => {
  TestBed.configureTestingModule({});
  service = TestBed.inject(AsyncMethodService);
});



// Async Method test Case for Id search

it('Should Check for id', async()=>{
  const users = 
  {
    id: 3,
    Name: "Bruce Banner",
    Email: "hulk1998@gammaradiation.com",
    password: "StrongestAvenger",
    Address: "New York, America"
  }
const result = await service.getAllUsers();
expect(result.find(item => item.id === 3)).toEqual(users); // Check for user if they contain data with this id

const nullUser = 
  {
    id: 0,
    Name: "",
    Email: "",
    password: "",
    Address: ""
  }

expect(result.find(item => item.id === 3)).not.toEqual(nullUser);
});
// End of Id Search Case




// Test Case to Check with Name Attribute
it('Should Check for User with Name At a Time', async()=>{
  const result = await service.getAllUsers();
expect(result.find(item=> item.Name=='Bruce Banner')).toBeTruthy();  // it will check whether this name is present in the User section

expect(result.find(item=> item.Name=='Tony Stark')).toBeTruthy(); // it will check whether this name is present in the User section

expect(result.find(item=> item.id==3)).toBe(result.find(item=>item.Name=='Bruce Banner')); // it will check whether this id with same name is present in the user data model or not

});
// End of Name Attribute Test Case

 // Lenght through Done Positive Senario
 it('should return the length of the user data using done Positive Senario',(done)=>{
  const result =  service.getAllUsers().then(data=>{
    expect(data.length).toBe(9); // Positive Test Senario
    });
  done();
});

// Lenght through Done Negative Senario
it('should return the length of the user data using done Negative Senario',(done)=>{
  const result =  service.getAllUsers().then(data=>{
    
    
    expect(data.length).toBe(9); // Negative test Senario

  });
  done();
});
// End of Length Function through Done 


 // Returns length using fakeasync  [POSITIVE TEST CASE]
 it('should return the length of the user data using fakeasync',fakeAsync(()=>{
  tick();
  expect(service.getAllUsers).toBeTruthy();
  const result =  service.getAllUsers().then(data=>{
    expect(data.length).toBe(9); // Positive Test Senario



    expect(data.length).not.toBe(8); // Negative test Senario
  });
}));


});
