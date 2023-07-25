import { DEFAULT_CURRENCY_CODE, LOCALE_ID,NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './core/components/navbar/navbar.component';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { SimuladorComponent } from './core/components/simulador/simulador.component';
import { HttpClientModule } from '@angular/common/http';

import ptBr from '@angular/common/locales/pt';
import { CommonModule, registerLocaleData } from '@angular/common';

import { NgxMaskModule, IConfig } from 'ngx-mask'

registerLocaleData(ptBr);


export const options: Partial<null|IConfig> | (() => Partial<IConfig>) = null;

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    SimuladorComponent,
    NavbarComponent    
  ],
  imports: [
    BrowserModule,CommonModule,
    AppRoutingModule,
    FormsModule,ReactiveFormsModule,
    HttpClientModule,
    NgxMaskModule.forRoot({dropSpecialCharacters:true}),   
  ],
  providers: [ { provide: LOCALE_ID, useValue: 'pt' }],
  bootstrap: [AppComponent]
})
export class AppModule { }
