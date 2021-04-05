import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { StringLengthComponent } from './string-length/string-length.component';
import { StringLenComponent } from './string-len/string-len.component';
import { MockReverseComponent } from './mock-reverse/mock-reverse.component';
import { MockTitleComponent } from './mock-title/mock-title.component';
import { TitleComponent } from './title/title.component';
import { LowerCaseComponent } from './lower-case/lower-case.component';
import { HelloComponent } from './hello/hello.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    StringLengthComponent,
    StringLenComponent,
    MockReverseComponent,
    MockTitleComponent,
    TitleComponent,
    LowerCaseComponent,
    HelloComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
