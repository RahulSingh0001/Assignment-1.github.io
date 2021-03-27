import { Router, ActivatedRoute } from '@angular/router';
import { ComServiceService } from './../com-service.service';
import { Component, OnInit } from '@angular/core';
import { FormArray, FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {
  id!: number;
  editForm!: FormGroup;
  companyBranch!: FormArray;
  constructor(private comServiceService: ComServiceService, private formBuilder: FormBuilder, private router: Router, private route:ActivatedRoute) { }

  ngOnInit(): void {
    let companyID = window.localStorage.getItem("companyId");
    if(!companyID) {
      alert("Invalid action.")
      this.router.navigate(['home']);
      return;
    }

    this.editForm = this.formBuilder.group({
      id: [],
      email: ['', Validators.required],
      name: ['', Validators.required],
      totalEmployee: [],
      address: ['', Validators.required],
      isCompanyActive: ['', Validators.required],
      totalBranch: [],
      companyBranch: this.formBuilder.array([])});
  
    this.comServiceService.getById(+companyID).subscribe(data=>{
      for(const index in data.companyBranch){
        this.getBranch();
      } 
      this.editForm.setValue(data); console.log(data);  });
    }

    Branch(): FormGroup{
      return this.formBuilder.group({
        branchId: '',
        branchName: '',
        branchAddress: ''
      });
    }
    
    getBranch(): void {
      this.companyBranch = this.editForm.get('companyBranch') as FormArray;
      this.companyBranch.push(this.Branch());
    }
  
    getControls() {
      return (this.editForm.get('companyBranch') as FormArray).controls;
    }
    get formdata(){
      return this.editForm.controls;
    }
  
    removeBranch(index:number){
      this.companyBranch.removeAt(index);
    }
    onUpdate() {
      console.log('Update Called!');
     this.comServiceService.update(this.editForm.value).subscribe(data => {
       this.router.navigate(['home']);
     },
       error => {
         alert(error);
       });
  }

}
