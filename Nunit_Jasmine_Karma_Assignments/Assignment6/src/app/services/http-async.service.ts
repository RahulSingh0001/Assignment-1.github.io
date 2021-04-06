import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {  Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Company } from '../model/company';

@Injectable({
  providedIn: 'root'
})
export class HttpAsyncService {
  private apiServer = "http://localhost:3000";
  constructor(private httpClient : HttpClient) { }
  //Adding Headers
  httpOptions = {
    headers : new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }

 // Method to create company and Observable
 // Usding JSON stringify to Convert the data into JSON format
  create(company: any) : Observable<Company>{
    
    company.totalBranch = company.companyBranch.length;
    return this.httpClient.post<Company>(this.apiServer +'/companies/',JSON.stringify(company), this.httpOptions)
  }
  // End of Create Company


  // Method to get all the data from Company model through APIServer i.e:- http://localhost:3000
  getAll(): Observable<Company[]>{
    return this.httpClient.get<Company[]>(this.apiServer + '/companies/')
    }
// End of get Method



  // Function to get details of company through Id
  getById(id: number) : Observable<Company>{
    return this.httpClient.get<Company>(this.apiServer + '/companies/' +id)
  }
  // End of Function to get details by id

  
  
  
  // Update function to update the data according to id of company
  update(company: Company) {
    return this.httpClient.put<Company>(this.apiServer + '/companies/' + company.id, JSON.stringify(company), this.httpOptions)
} 
// End of Update Function



  // Function to delete the company by selecting the id
  delete(id: number) : Observable<Company>{
    return this.httpClient.delete<Company>(this.apiServer + '/companies/' +id, this.httpOptions)
  }
// End of Delete function

  

}






