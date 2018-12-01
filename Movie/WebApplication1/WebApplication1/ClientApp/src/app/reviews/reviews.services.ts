import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Movie } from "../models/movie.model";
import {Review } from '../models/review.model';



@Injectable()
export class ReviewsServices {

  private url = 'api/reviews';

  constructor(private http: HttpClient) { }

  getReviews() {
    return this.http.get("api/reviews");
  }

  getReviewById(id: string) {
    return this.http.get('/api/moviereviews/' + id);
  }

  AddReview(review: Review) {
    return this.http.post("api/reviews/", review);
  }

  deleteReview(id: string) {
    return this.http.delete(this.url + '/' + id);
  }

  

  updateReview(review: Review) {
    return this.http.put(this.url, review);
  }

}
