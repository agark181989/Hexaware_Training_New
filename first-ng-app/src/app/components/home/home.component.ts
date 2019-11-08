import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  name:string;
  today:Date;
  isMarried:boolean = true;
  size:number = 30;
  colorCode:string = "#000000";

  products:any[]=[
    {id:1, name:"Burger", price:80, quantity:10},
    {id:2, name:"Pizza", price:280, quantity:5},
    {id:3, name:"Pepsi", price:40, quantity:0},
    {id:4, name:"Mirinda", price:45, quantity:1090}    
  ]
  constructor() { 
    this.name = "Rohit Agarwal";
    this.today = new Date();
  }

  ngOnInit() {
  }

  toggleMarried(){
    this.isMarried = !this.isMarried;
  }

  updateFont(ctrl){    
    this.size = ctrl.value;
  }

  updateColor(ctrl){
    this.colorCode = ctrl.value;
  }
}
