import { Component, OnInit } from '@angular/core';
import { CatalogService } from 'src/app/services';
import { Observable } from 'rxjs';
import { CatalogItem } from 'src/app/models';
import { ThrowStmt } from '@angular/compiler';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  products:Observable<CatalogItem[]>;
  constructor(private catlgSvc:CatalogService) { 
    this.products = this.catlgSvc.getProducts();
  }

  ngOnInit() {
  }

}
