import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Movie } from "../models/movie.model";


@Injectable()
export class MoviesServices {

  private url = 'api/movies';

  constructor(private http: HttpClient) { }

  getMovies() {
    return this.http.get("api/movies");
  }

  AddMovie(movie: Movie) {
    return this.http.post("api/movies/", movie);
  }

  deleteMovie(id: string) {
    return this.http.delete(this.url + '/' + id);
  }

  getMovie(id: string) {
    debugger;
    return this.http.get<any>(this.url + '/' +  id);
  }

  updateMovie(movie: Movie) {
   return this.http.put(this.url, movie);
  }

}
