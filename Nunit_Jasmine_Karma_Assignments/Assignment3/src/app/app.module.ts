import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UpperCaseComponent } from './upper-case/upper-case.component';
import { TitlecheckComponent } from './titlecheck/titlecheck.component';
import { LowerCaseComponent } from './lower-case/lower-case.component';
import { StringLengthComponent } from './string-length/string-length.component';
import { StringReverseComponent } from './string-reverse/string-reverse.component';
import { TitleCaseComponent } from './title-case/title-case.component';

@NgModule({
  declarations: [
    AppComponent,
    UpperCaseComponent,
    TitlecheckComponent,
    LowerCaseComponent,
    StringLengthComponent,
    StringReverseComponent,
    TitleCaseComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
