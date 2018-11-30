import { Component, OnInit } from '@angular/core';
import { MoviesServices } from '../movies.services';
import { Movie } from '../../models/movie.model';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-edit-movie',
  templateUrl: './edit-movie.component.html',
  styleUrls: ['./edit-movie.component.css']
})
export class EditMovieComponent implements OnInit {

  movie: Movie;
  editMoveForm: FormGroup;

  constructor(private moviseServices: MoviesServices, private router: Router, private route: ActivatedRoute) {
    debugger;
    
   
   
  }

  ngOnInit() {
    const id: string = this.route.snapshot.params['id'];
    this.getMovieById(id);
    
  }

  getMovieById(id: string) {
    this.moviseServices.getMovie(id).subscribe(response => {
      this.editMoveForm = new FormGroup({
        'id': new FormControl(response.id, Validators.required),
        'movieName': new FormControl(response.movieName, Validators.required),
        'directorName': new FormControl(response.directorName, Validators.required),
        'releaseYear': new FormControl(response.releaseYear, Validators.required),
      });
      this.movie = response;
      console.log(this.movie);
    });
  }

  edit() {
    if (this.editMoveForm.valid) {
      this.moviseServices.updateMovie(this.editMoveForm.getRawValue()).subscribe(resp => {
        console.log(this.editMoveForm);
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


