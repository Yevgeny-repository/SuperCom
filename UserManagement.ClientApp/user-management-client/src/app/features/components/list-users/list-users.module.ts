// NG
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

// USERS
import { ListUsersComponent } from './list-users.component';

@NgModule({
	declarations: [ListUsersComponent],
	exports: [ListUsersComponent],
	imports: [
        CommonModule,
        FormsModule,
		HttpClientModule,
		RouterModule 
	],
})
export class ListUsersModule {
}
