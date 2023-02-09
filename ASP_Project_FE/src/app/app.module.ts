import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { MainPageComponent } from './main-page/main-page.component';
import { ComicsComponent } from './comics/comics.component';
import { LocationsComponent } from './locations/locations.component';
import { ComicStoreComponent } from './comic-store/comic-store.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: '', component: MainPageComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'comics', component: ComicsComponent },
  { path: 'locations', component: LocationsComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    LoginComponent,
    MainPageComponent,
    ComicsComponent,
    LocationsComponent,
    ComicStoreComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
