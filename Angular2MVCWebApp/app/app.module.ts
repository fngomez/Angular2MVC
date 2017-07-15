import { NgModule } from '@angular/core';
import { APP_BASE_HREF } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
 
 @NgModule({
    imports: [BrowserModule, ReactiveFormsModule, HttpModule],
    declarations: [],
    providers: [{ provide: APP_BASE_HREF, useValue: '/' }],
    bootstrap: []
})

export class AppModule { }