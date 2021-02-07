// NG
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

// USERS
import { CreateUserWizardModule } from './components/create-user-wizard/create-user-wizard.module';
import { ListUsersModule } from './components/list-users/list-users.module';


@NgModule({
	imports: [
		CommonModule,
	],
	exports: [
		CreateUserWizardModule,
		ListUsersModule,
	],
	declarations: []
})
export class FeatureModule {
}
