import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { UserService } from 'src/app/services';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm: FormGroup;
  constructor(private fb: FormBuilder, private userSvc: UserService, private router: Router) {
    this.loginForm = this.fb.group({
      username: new FormControl("", Validators.required),
      password: new FormControl("", Validators.compose([Validators.required, Validators.minLength(8)]))
    })
  }

  ngOnInit() {
  }

  public get Username() {
    return this.loginForm.controls["username"]
  }
  public get Password() {
    return this.loginForm.controls["password"]
  }

  login() {
    if (this.loginForm.valid) {
      let username = this.loginForm.value.username;
      let password = this.loginForm.value.password;
      this.userSvc.getToken(username, password)
        .subscribe(
          result => {
            console.log(result);
            this.userSvc.saveUserState(result);
            this.router.navigate(['/']);
          },
          err => { console.log(err); alert("Error is validating user"); }
        )
    } else {
      alert("Invalid username/password");
    }
  }
}
