import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, BehaviorSubject } from 'rxjs';
import { User } from 'src/app/models';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  //readonly API_URL="http://localhost:62316/api/auth";
  readonly API_URL="https://rohit-identityapi.azurewebsites.net/api/auth";
  userSubject:BehaviorSubject<any>;
  currentUser:Observable<any>;

  constructor(private http:HttpClient) { 
    this.userSubject=new BehaviorSubject<any>(JSON.parse(localStorage.getItem("user")));
    this.currentUser=this.userSubject.asObservable();
  }

  addUser(user:User):Observable<User>{      
    return this.http.post<User>(`${this.API_URL}/register`, user);
  }

  getToken(username:string, password:string):Observable<any>{
    let login={
      username, password
    };
    return this.http.post<any>(`${this.API_URL}/token`, login);
  }

  saveUserState(userData){
    localStorage.setItem("user", JSON.stringify(userData));
    this.userSubject.next(userData);
  }

  clearUserState(){
    localStorage.clear();
    this.userSubject.next(null);
  }

  
  public get User() : any {
    return this.userSubject.value;
  }
  
}
