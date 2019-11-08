import { Component, OnInit } from '@angular/core';
import { CatalogItem } from 'src/app/models';
import { CatalogService } from 'src/app/services';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {

  product: CatalogItem;
  constructor(private catlogSvc: CatalogService, private router:Router) {
    this.product = {
      name: "",
      price: 0,
      quantity: 0,
      reorderLevel: 0,
      manufacturingDate: undefined
    }
  }

  ngOnInit() {
  }

  save(frm, img) {
    if (frm.valid) {
      let formData: FormData = new FormData();
      formData.append("name", this.product.name);
      formData.append("price", this.product.price.toString());
      formData.append("quantity", this.product.quantity.toString());
      formData.append("reorderLevel", this.product.reorderLevel.toString());
      formData.append("manufacturingDate", this.product.manufacturingDate.toString());
      formData.append("image", img.files[0], img.files[0].name);
      this.catlogSvc.addProduct(formData)
        .subscribe(
          result => {
            console.log(result);
            this.router.navigate(['/']);
          },
          err => {
            console.log(err);
            alert("Error in adding successfully");
          }
        )
    }
    else {
      alert("Invalid form data");
    }
  }
}
