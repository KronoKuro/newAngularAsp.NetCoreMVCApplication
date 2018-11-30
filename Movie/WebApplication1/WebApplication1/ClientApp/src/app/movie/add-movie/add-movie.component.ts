import { Component, OnInit } from '@angular/core';
import { MoviesServices } from '../movies.services';
import { Movie } from '../../models/movie.model';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-movie',
  templateUrl: './add-movie.component.html',
  styleUrls: ['./add-movie.component.css']
})
export class AddMovieComponent implements OnInit {

  movies: Movie;
  addMoveForm: FormGroup;

  constructor(private moviseServices: MoviesServices, private router: Router) {
    debugger;
    this.addMoveForm = new FormGroup({
      'movieName': new FormControl('', [Validators.required]),
      'directorName': new FormControl('', Validators.required),
      'releaseYear': new FormControl('', Validators.required),
    })
  }
  ngOnInit(){

  }

  add() {
    if (this.addMoveForm.valid) {
      this.moviseServices.AddMovie(this.addMoveForm.getRawValue()).subscribe(resp => {
        console.log(this.addMoveForm);
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


