import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListComponent } from './listings/containers/list/list.component';
import { AddComponent } from './listings/containers/add/add.component';
import { DetailsComponent } from './listings/containers/details/details.component';

const routes: Routes = [
  { path: 'dashboard', component: ListComponent },
  { path: 'listing/add', component: AddComponent },
  { path: 'listing/:id', component: DetailsComponent },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
