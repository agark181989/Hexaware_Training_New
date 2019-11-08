import { Component, OnInit } from '@angular/core';
import { AddserviceService } from 'src/app/services';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  userEvents:Observable<Event[]>;
  constructor(private eventSvc:AddserviceService) { 
    this.userEvents= this.eventSvc.getEvent();
  }

  ngOnInit() {
  }

}
