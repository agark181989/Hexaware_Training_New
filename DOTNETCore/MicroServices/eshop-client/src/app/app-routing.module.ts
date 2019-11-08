import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent, AddProductComponent, RegisterComponent, LoginComponent } from './components';


const routes: Routes = [
  { path:"", component:HomeComponent, pathMatch:"full" },
  { path:"products/add", component:AddProductComponent },
  { path:"register", component:RegisterComponent },
  { path:"login", component:LoginComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
