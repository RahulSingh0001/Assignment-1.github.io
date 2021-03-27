import { ComServiceService } from './com-service.service';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateComponent } from './create/create.component';

import { UpdateComponent } from './update/update.component';
import { HomeComponent } from './home/home.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [CreateComponent, HomeComponent, UpdateComponent],
  imports: [
    CommonModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers:[ComServiceService]
})
export class CompanyModule { }
