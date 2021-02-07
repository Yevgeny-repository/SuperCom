// NG
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

// VENDOR
import { NgxNotifierService } from 'ngx-notifier';
import { SubSink } from 'subsink';

// USERS
import { UserModel } from '@shared/models';
import { UsersService } from '@shared/services/users/users-shared.service';

@Component({
  selector: 'app-create-user-wizard',
  templateUrl: './create-user-wizard.component.html',
  styleUrls: ['./create-user-wizard.component.scss']
})
export class CreateUserWizardComponent implements OnInit {

  userForm: FormGroup;
  userModel: UserModel;
  imageUrlBase64: string;
  imageUrl: string = "/assets/img/default-image.png";
  fileToUpload: File = null;
  submitted = false;
  private subs = new SubSink();

  constructor(private usersService: UsersService,
    private ngxNotifierService: NgxNotifierService,
    ) { }

  ngOnInit() {

    this.userForm = new FormGroup({
      firstName: new FormControl(),
      lastName: new FormControl(),
      userName: new FormControl(),
      timeZone: new FormControl(),
      webSite: new FormControl(),
      phoneSkype: new FormControl(),
      about: new FormControl(),
      imageData: new FormControl(),
    })
  }

  handleFileInput(file: FileList) {
    this.fileToUpload = file.item(0);

    //Show image preview
    var reader = new FileReader();
    reader.onload = (event: any) => {
      this.imageUrl = event.target.result;
      this.imageUrlBase64 = event.target.result;
      console.log(this.imageUrl);
    }
    reader.readAsDataURL(this.fileToUpload);
  }

  onSubmit() {
    this.submitted = true;
    if (!this.userForm.valid)
      return;

    this.userModel = new UserModel(
      '',
      this.userForm.get('userName').value,
      this.userForm.get('firstName').value,
      this.userForm.get('lastName').value,
      this.userForm.get('timeZone').value,
      this.userForm.get('webSite').value,
      this.userForm.get('phoneSkype').value,
      this.imageUrlBase64,
      this.userForm.get('about').value,
    );
    this.subs.sink = this.usersService.createUser(this.userModel).subscribe(data => this.createUserSub(data),
    (error) => this.ngxNotifierService.createToast('Error! Please contact administrator', 'danger')
    );
  }
  createUserSub(data: boolean): void {
    {
      this.userForm.reset();
      this.imageUrlBase64 = "";
      this.imageUrl = "/assets/img/default-image.png"
      if (data) {
        this.ngxNotifierService.createToast('User was created successfully', 'success')
      }
    }
  }

  public ngOnOestroy() {
    this.subs.unsubscribe();
    this.ngxNotifierService.clear();
  }
}
