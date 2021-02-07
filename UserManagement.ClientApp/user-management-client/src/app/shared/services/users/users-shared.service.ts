// NG
import { Injectable, Injector } from '@angular/core';

// VENDOR
import { Observable } from 'rxjs';

// WEATHER
import { BaseHttpService } from '@core/services/http';
import { UserModel } from '@shared/models/user.model';

@Injectable({providedIn: 'root'})
export class UsersService extends BaseHttpService {
	private user_endpoint: string = 'api/users/';

	constructor(injector: Injector) {
		super(injector);
	}

	/**
	 * Get Users
	 */
	public getUsers(): Observable<UserModel[]> {
		return this.get(this.user_endpoint, {});
	}

	
	/**
	 * Get User
	 */
	public getUser(id: string): Observable<UserModel[]> {
		return this.get(this.user_endpoint, {
			id: id,
		});
	}

	/**
	 * CreateUser
	 */
	public createUser(user: UserModel): Observable<boolean>{
		return this.post<boolean>(`${this.user_endpoint}`, user);
	}
}
