import { Component, OnInit } from '@angular/core';
import { ReviewsServices } from './reviews.services';
import { Router, ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-reviews',
  templateUrl: './reviews.component.html',
  styleUrls: ['./reviews.component.css']
})
export class ReviewComponent implements OnInit {

  reviews: any;

  constructor(private reviewsServices: ReviewsServices, private route: ActivatedRoute) { }

  ngOnInit() {
    const id = this.route.snapshot.params['id'];
    this.reviewsServices.getReviewById(id).subscribe(response => {
      this.reviews = response;
      console.log(this.reviews);
    });
  }

}
