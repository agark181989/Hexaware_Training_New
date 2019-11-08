import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { AboutComponent } from './components/about/about.component';
import { ReversePipe } from './pipes/reverse.pipe';
import { AvailabilityPipe } from './pipes/availability.pipe';


@NgModule({
  declarations: [ // component, pipes and directives
    AppComponent, 
    HomeComponent, 
    AboutComponent, 
    ReversePipe, AvailabilityPipe
  ],
  imports: [ // any imported module (Custom//built-in module)
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
