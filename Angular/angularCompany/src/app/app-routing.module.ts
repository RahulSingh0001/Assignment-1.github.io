import { UpdateComponent } from './company/update/update.component';
import { CreateComponent } from './company/create/create.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './company/home/home.component';

const routes: Routes = [
  {path:'', redirectTo:'/home',pathMatch:'full'},
  {path:'home', component:HomeComponent},
  {path:'create', component:CreateComponent},
  {path:'update', component: UpdateComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
