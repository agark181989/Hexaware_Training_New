import { Component, OnInit, OnChanges, OnDestroy } from '@angular/core';
import { Product } from 'src/app/models';
import { ProductService } from 'src/app/services';
import { Observable } from 'rxjs';

@Component({
  selector: 'home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit, OnChanges, OnDestroy {
  //One approach for using observable. Here only convert the product array to observale
  // type and using async pipe  
  products:Observable<Product[]>;  

  constructor(private productSvc:ProductService) { 
    this.products = this.productSvc.getProducts();
  }

  ngOnInit() { 
    console.log("OnInit executed");   
  }
  ngOnChanges(){
    console.log("OnChange executed");   
  }
  ngOnDestroy(){
    console.log("OnDestroy executed");   
  }

}
