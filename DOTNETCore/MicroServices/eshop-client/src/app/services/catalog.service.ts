import { Injectable } from '@angular/core';
import { HttpClient}  from '@angular/common/http';
import { CatalogItem } from '../models';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CatalogService {

  //readonly API_BASE:string="http://localhost:52011/api/catalog";
  readonly API_BASE:string="https://rohit-catalogplanapi.azurewebsites.net/api/catalog";
  constructor(private http:HttpClient) { }

  addProduct(formData: FormData):Observable<CatalogItem>{
   return this.http.post<CatalogItem>(`${this.API_BASE}/product`, formData);
  }

  getProducts():Observable<CatalogItem[]>{
    return this.http.get<CatalogItem[]>(this.API_BASE);
  }
}
