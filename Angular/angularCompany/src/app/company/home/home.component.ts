import { ComServiceService } from './../com-service.service';
import { CompanyModel } from './../company-model';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  companies : CompanyModel[]=[];

  constructor(public comServiceService: ComServiceService, private router: Router) { }

  ngOnInit(): void {
   


        // subscribing getAll() to retrieve all companies data
        this.comServiceService.getAll().subscribe((data : CompanyModel[])=>{
         
          this.companies = data;
      })
      }
     //delete button click event method
  deleteData(companies:CompanyModel){
    
    this.comServiceService.delete(companies.id).subscribe(data=>{
      this.comServiceService.getAll().subscribe((data:CompanyModel[])=>{
        this.companies=data;
      });
    });
  };



  //Edit button click event method
  editData(company:CompanyModel):void{
    
    localStorage.removeItem('companyId');
    localStorage.setItem('companyId', company.id.toString());
    this.router.navigate(['update']);
  }


   //
   detailData(company :CompanyModel):void{
    localStorage.removeItem('companyId');
    localStorage.setItem('companyId', company.id.toString());
    this.router.navigate(['details']);
  }


  }


