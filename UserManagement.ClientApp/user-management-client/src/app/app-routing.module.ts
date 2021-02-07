import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CreateUserWizardComponent } from '@features/components/create-user-wizard/create-user-wizard.component';
import { ListUsersComponent } from '@features/components/list-users/list-users.component';


const routes: Routes = [
  { 
    path: 'list-users',
    component: ListUsersComponent,
  },
  { 
    path: 'create-user-wizard',
    component: CreateUserWizardComponent,
  },
  { path: '',   redirectTo: '/list-users', pathMatch: 'full' }, 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
