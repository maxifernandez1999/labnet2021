import { NgModule } from '@angular/core';
import { ModalDeleteComponent } from './modal-delete/modal-delete.component';
import { TableShippersComponent } from './table-shippers/table-shippers.component';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { ReactiveFormsModule } from '@angular/forms';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { BrowserModule } from '@angular/platform-browser';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { RegisterComponent } from './register/register.component';
import { AlertsComponent } from './alerts/alerts.component';



@NgModule({
  declarations: [
    HomeComponent,
    ModalDeleteComponent,
    TableShippersComponent,
    HeaderComponent,
    FooterComponent,
    RegisterComponent,
    AlertsComponent
  ],
  imports:[
    BrowserModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    CommonModule
  ]
})
export class HomeModule { }
