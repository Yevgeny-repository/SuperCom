import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateUserWizardComponent } from './create-user-wizard.component';

describe('CreateUserWizardComponent', () => {
  let component: CreateUserWizardComponent;
  let fixture: ComponentFixture<CreateUserWizardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateUserWizardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateUserWizardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
