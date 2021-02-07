// NG
import { Component, OnInit } from '@angular/core';
import { UserModel } from '@shared/models';

// VENDOR
import { Observable } from 'rxjs';
import { SubSink } from 'subsink';

// USERS
import { UsersService } from '@shared/services/users/users-shared.service';


@Component({
  selector: 'app-list-users',
  templateUrl: './list-users.component.html',
  styleUrls: ['./list-users.component.scss']
})
export class ListUsersComponent implements OnInit {

  users: UserModel[];
  users$: Observable<any>;
  private subs = new SubSink();

  constructor(private usersService: UsersService) { }

  ngOnInit() {
    this.users$ = this.usersService.getUsers();
    this.subs.sink = this.users$.subscribe(data => this.users = data);
  }
  
  public ngOnOestroy() {
    this.subs.unsubscribe();
  }
}
