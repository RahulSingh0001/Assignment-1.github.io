import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ComServiceService } from './company/com-service.service';
import { CompanyModule } from './company/company.module';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CompanyModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [ComServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
