import { catchError } from 'rxjs/operators';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, throwError } from 'rxjs';
import { CompanyModel } from './company-model';


@Injectable({
  providedIn: 'root'
})

export class ComServiceService {
private apiServer= "http://localhost:3000";

httpOptions ={
  headers : new HttpHeaders({
    'Content-Type': 'application/json'

  })
}
  constructor(private httpClient: HttpClient) { }

  create(company: any) : Observable<CompanyModel>{
    debugger;
    company.totalBranch = company.companyBranch.length;
    return this.httpClient.post<CompanyModel>(this.apiServer +'/companies/',JSON.stringify(company), this.httpOptions)
    .pipe(catchError(this.errorHandler))
  }

 //Get all Companies List
 getAll(): Observable<CompanyModel[]>{
  return this.httpClient.get<CompanyModel[]>(this.apiServer + '/companies/')
  .pipe(catchError(this.errorHandler))
}

//Get Company by ID
getById(id: any) : Observable<CompanyModel>{
  return this.httpClient.get<CompanyModel>(this.apiServer + '/companies/' +id)
  .pipe(catchError(this.errorHandler))
}

//Edit or Update Company Details
update(company: CompanyModel) {
  return this.httpClient.put<CompanyModel>(this.apiServer + '/companies/' + company.id, JSON.stringify(company), this.httpOptions)
  .pipe(
    catchError(this.errorHandler)
  )
} 

//Delete Company data
delete(id: number) : Observable<CompanyModel>{
  return this.httpClient.delete<CompanyModel>(this.apiServer + '/companies/' +id, this.httpOptions)
  .pipe(catchError(this.errorHandler))
}
















  errorHandler(error: any) {
    let errorMsg = '';
 
     if(error.error instanceof ErrorEvent){
       errorMsg = error.error.message;
     }
     else{
       errorMsg = `ErrorCode : ${error.status}\nMessage: $ {error.Message}`;
     }
     console.log(errorMsg);
     return throwError(errorMsg);
   }














}
