import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AddserviceService {

  readonly api_url = "http://localhost:3000";

  constructor(private http:HttpClient) { }  

  getEvent():Observable<Event[]>{
    return this.http.get<Event[]>(`${this.api_url}/event/`);
  }

  getEventById(id:number):Observable<Event>{
    return this.http.get<Event>(`${this.api_url}/event/${id}`);
  }

  addEvent(event:Event):Observable<Event>{  
    return this.http.post<Event>(`${this.api_url}/event`, event);
  }
}
