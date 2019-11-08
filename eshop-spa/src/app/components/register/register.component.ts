import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { User } from 'src/app/models';
import { UserService } from 'src/app/services';

@Component({
  selector: 'register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  userForm:FormGroup;
  constructor(private fb:FormBuilder, private userSvc:UserService) { 
    this.userForm=this.fb.group({
      username:new FormControl("", Validators.required),
      password:new FormControl("", Validators.compose([Validators.required, Validators.minLength(8)])),
      fullname:new FormControl("", Validators.required),
      email:new FormControl("", Validators.compose([Validators.required, Validators.email])),
      mobile:["", Validators.compose([Validators.required, Validators.maxLength(10)])]
    })
  }

  ngOnInit() {
  }
   
  public get Fullname(){
    return this.userForm.controls["fullname"]
  }
  public get Username(){
    return this.userForm.controls["username"]
  }
  public get Password(){
    return this.userForm.controls["password"]
  }
  public get Email(){
    return this.userForm.controls["email"]
  }
  public get Mobile(){
    return this.userForm.controls["mobile"]
  }

  register(){
    if(this.userForm.valid){
      let user:User=this.userForm.value;
      this.userSvc.addUser(user)
      .subscribe(
         result=>{
           console.log(result);
           alert("Registered successfully");
         },
         err=>{alert("Error in registering user")}
      )
    }
    else{
      alert("Invaild form data");
    }
  }
}
