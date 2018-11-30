import { Component, OnInit } from '@angular/core';
import { MoviesServices } from './movies.services';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css']
})
export class MovieComponent implements OnInit {

  movies: any;

  constructor(private moviseServices: MoviesServices) { }

  ngOnInit() {
    this.moviseServices.getMovies().subscribe(response => {
      this.movies = response;
      console.log(this.movies);
    });
  }

}
