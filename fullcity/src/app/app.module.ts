import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CitylistComponent } from './citylist/citylist.component';
import { CitydetailsComponent } from './citydetails/citydetails.component';

@NgModule({
  declarations: [
    AppComponent,
    CitylistComponent,
    CitydetailsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
