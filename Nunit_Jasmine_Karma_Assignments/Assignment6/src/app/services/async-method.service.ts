import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AsyncMethodService {
  getAllUsers = async () => {
    const users = [
      {
        id: 1,
        Name: "Rahul Singh",
        Email: "rahul@gmail.com",
        password: "123456" ,
        Address: "Udaipur"
      },
      {
        id: 2,
        Name: "Tony Stark",
        Email: "starkindustry@starkexpo.com",
        password: "jarvis",
        Address: "Malibu, California"
      },
      {
        id: 3,
        Name: "Bruce Banner",
        Email: "hulk1998@gammaradiation.com",
        password: "StrongestAvenger",
        Address: "New York, America"
      },
      {
        id: 4,
        Name: "Thor",
        Email: "odinson@godofthunder.co.in",
        password: "PointBreak",
        Address: "Asgard"
      },
      {
        id: 5,
        Name: "Peter Parker",
        Email: "spider@man.com",
        password: "WeWonMr.Stark",
        Address: "New York, America"
      },
      {
        id: 6,
        Name: "Steve Rogers",
        Email: "captainamerica@firstavengers.com",
        password: "ICanDoThisWholeDay",
        Address: "Berlin"
      },
      {
        id: 7,
        Name: "Scott Lang",
        Email: "ant@man.co.in",
        password: "TimeDakaiti",
        Address: "QuantamRealm"
      },
      {
        id: 8,
        Name: "Dr. Stephen Strange",
        Email: "dr@strange.kamataz.com",
        password: "Shamballa-Kamataz",
        Address: "Kathmandu, Nepal"
      },
      {
        id: 9,
        Name: "Clint Barton",
        Email: "hawkeye@arrow.sheild.co.in",
        password: "INeverMissedIt",
        Address: "Germany"
      },
     


    ]
    return users;
  }
  constructor() { }
}