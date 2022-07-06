import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventosComponent } from './Eventos/eventos.component';
import { PalestrantesComponent } from './Palestrantes/Palestrantes.component';

@NgModule({
  declarations: [
    AppComponent,
    EventosComponent,
      PalestrantesComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
