import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LeadTrackComponent } from './lead-track/lead-track.component';

@NgModule({
  declarations: [
    AppComponent,
    LeadTrackComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent, LeadTrackComponent]
})
export class AppModule { }
