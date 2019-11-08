import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, BehaviorSubject } from 'rxjs';
import { User } from 'src/app/models';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  readonly API_URL="http://localhost:3000/users";
  userSubject:BehaviorSubject<any>;
  currentUser:Observable<any>;

  constructor(private http:HttpClient) { 
    this.userSubject=new BehaviorSubject<any>(JSON.parse(localStorage.getItem("user")));
    this.currentUser=this.userSubject.asObservable();
  }

  addUser(user:User):Observable<any>{    
    return this.http.post<any>(this.API_URL, user);
  }

  getUser(username:string, password:string):Observable<any>{
    let url =`${this.API_URL}?username=${username}&password=${password}`;
    return this.http.get<any>(url);
  }

  saveUserState(user:User){
    delete user.password;
    localStorage.setItem("user", JSON.stringify(user));
    this.userSubject.next(user);
  }

  removeUserState(){
    localStorage.clear();
    this.userSubject.next(null);
  }

  public get LoggedUser():any{
    return this.userSubject.value;
  }
}
