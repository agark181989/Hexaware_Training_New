import { Injectable } from '@angular/core';
import { Category, Product } from '../models';
import { Observable, of, throwError } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  

  // categories:Category[]=[
  //   { id:101, name:"Mobiles", description:"SmartPhone and feature phone" },
  //   { id:102, name:"Televisions", description:"Smart TV and normal TV" },
  //   { id:103, name:"Laptops", description:"Top brand laptops and notebooks" }
  // ];

  // products:Product[]=[
  //   { id:1, name:"Mi 7", brand:"Xiamoi", categoryId:101, price:21999, quantity:25, taxRate:8,    
  //       manufacturingDate:new Date(2016,6,15), reorderLevel:10, imageUrl:"assets/mi7.webp"},

  //   { id:2, name:"Redmi Note 7", brand:"Xiamoi", categoryId:101, price:17999, quantity:0, taxRate:8,
  //       manufacturingDate:new Date(2016,8,15), reorderLevel:5, imageUrl:""},
    
  //   { id:3, name:"Envy 13", brand:"HP", categoryId:103, price:72000, quantity:10, taxRate:8,
  //       manufacturingDate:new Date(2016,6,15), reorderLevel:3, imageUrl:"assets/hpenvy13.jpg"},
  // ];

   readonly API_URL="http://localhost:3000"

  constructor(private http:HttpClient) { }

  getProducts():Observable<Product[]>{
    return this.http.get<Product[]>(`${this.API_URL}/products`);
  }

  getProductById(id:number):Observable<Product>{    
    return this.http.get<Product>(`${this.API_URL}/products/${id}`);
  }

  addProduct(product:Product):Observable<Product>{
    return this.http.post<Product>(`${this.API_URL}/products`, product);

    // let lastId = this.products[this.products.length-1].id;
    // product.id=lastId+1;
    // this.products.push(product);
    // //return throwError("it's not valid");
    // return of(product);
  }

  removeProduct(id:number):Observable<any>{
    return this.http.delete<any>(`${this.API_URL}/products/${id}`);

    // let itemIndex = this.products.findIndex(e=>e.id==id);
    // this.products.splice(itemIndex, 1);
    // return undefined;
  }

  getCategories():Observable<Category[]>{
    return this.http.get<Category[]>(`${this.API_URL}/categories`);
    //return of(this.categories);
  }
}
