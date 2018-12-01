import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, ActivatedRouteSnapshot } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { MovieComponent } from './movie/movie.component';
import { MoviesServices } from './movie/movies.services';
import { AddMovieComponent } from './movie/add-movie/add-movie.component';
import { EditMovieComponent } from './movie/edit-movie/edit-movie.component';
import { DeleteMovieComponent } from './movie/delete-movie/delete-movie.component';
import { ReviewsServices } from './reviews/reviews.services';
import { ReviewComponent } from './reviews/reviews.component';



@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    MovieComponent,
    AddMovieComponent,
    EditMovieComponent,
    DeleteMovieComponent,
    ReviewComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      //{ path: '', redirectTo:'home', component: HomeComponent, pathMatch: 'full' },
      { path: 'home', component: HomeComponent },
      { path: 'movies', component: MovieComponent },
      { path: 'reviews/:id', component: ReviewComponent },
      { path: 'add-movie', component: AddMovieComponent },
      { path: 'edit-movie/:id', component: EditMovieComponent },
      { path: 'delete-movie/:id', component: DeleteMovieComponent },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: '**', redirectTo: 'home' },
    ])
  ],
  providers: [MoviesServices, ReviewsServices],
  bootstrap: [AppComponent]
})
export class AppModule { }
