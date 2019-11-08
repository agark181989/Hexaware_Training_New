import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent } from '@angular/common/http';
import { UserService } from '../services';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService implements HttpInterceptor {

  constructor(private userSvc: UserService) { }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    if (this.userSvc.User) {
      if(req.url.endsWith("/api/catalog/product")&& req.method=="POST"){
        //When add product with image, we don't need to set content type as json.
        req = req.clone({
          setHeaders: {
            "Accept":"application/json",
            "Authorization": `Bearer ${this.userSvc.User.token}`
          }
        });
      }
      else{
        req = req.clone({
          setHeaders: {
            "Accept":"application/json",
            "Content-Type":"application/json",
            "Authorization": `Bearer ${this.userSvc.User.token}`
          }
        });
      }
      
    }
    return next.handle(req);
  }
}
