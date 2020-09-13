import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { HttpClientModule, HttpClient } from '@angular/common/http'; 

import { RoboComponent } from './robo/robo.component';
import { RoboService } from './services/robo.service';

@NgModule({
  declarations: [
    AppComponent,
    RoboComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [HttpClientModule, RoboService],
  bootstrap: [AppComponent]
})
export class AppModule { }
