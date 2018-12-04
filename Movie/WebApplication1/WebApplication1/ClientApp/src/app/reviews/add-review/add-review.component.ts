import { Component, OnInit } from '@angular/core';
import { Movie } from '../../models/movie.model';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ReviewsServices } from '../reviews.services';


@Component({
  selector: 'app-add-review',
  templateUrl: './add-review.component.html',
  styleUrls: ['./add-review.component.css']
})
export class AddReviewComponent implements OnInit {

  movies: Movie;
  addReviewForm: FormGroup;

  constructor(private moviseServices: ReviewsServices, private router: Router) {
    debugger;
    this.addReviewForm = new FormGroup({
      'revieweName': new FormControl('', [Validators.required]),
      'revieweComments': new FormControl('', Validators.required),
      'reviewerRating': new FormControl('', Validators.required),
      'movieId': new FormControl('', Validators.required),
    });
  }
  ngOnInit() {

  }

  add() {
    if (this.addReviewForm.valid) {
      this.moviseServices.AddReview(this.addReviewForm.getRawValue()).subscribe(resp => {
        console.log(this.addReviewForm);
        this.router.navigate(['movies']);
      },
        error => {
          alert(error['error']);
        });
      alert('form submitted');
    } else {
      alert('Ошибка заполнения полей'); //{7}
    }
  }

}


