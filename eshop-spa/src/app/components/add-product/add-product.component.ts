import { Component, OnInit } from '@angular/core';
import { Product, Category } from 'src/app/models';
import { ProductService } from 'src/app/services';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {
  
  product:Product;
  categories:Observable<Category[]> 
  formStatus:any={
    submitted:false,
    valid:true
  } 

  navigationEnable:boolean=false;

  constructor(private prodcutSvc:ProductService, private router:Router) {
        this.categories = this.prodcutSvc.getCategories();
        this.product={       
            name:"",      
            price:undefined,
            quantity:undefined,
            reorderLevel:undefined,
            taxRate:undefined,
            manufacturingDate:undefined,
            imageUrl:"",
            brand:"",
            categoryId:undefined
          }
   }

  ngOnInit() {
  }

  save(form){
    if(form.valid){
      this.formStatus.submitted = true;
      this.prodcutSvc.addProduct(form.value)
      .subscribe(
        res=>{
           this.navigationEnable = true;
           this.router.navigate(['/'])},
        err=>{ this.formStatus.valid = false; }
      );
    }
    else{
      this.formStatus.valid = false;
    }   
  }
}
