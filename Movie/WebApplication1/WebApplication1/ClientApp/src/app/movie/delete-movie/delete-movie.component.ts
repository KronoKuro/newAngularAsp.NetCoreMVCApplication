import { Component, OnInit } from '@angular/core';
import { MoviesServices } from '../movies.services';
import { Movie } from '../../models/movie.model';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-delete-movie',
  templateUrl: './delete-movie.component.html',
  styleUrls: ['./delete-movie.component.css']
})
export class DeleteMovieComponent implements OnInit {

  constructor(private moviseServices: MoviesServices, private router: Router, private route: ActivatedRoute) {
    
   
  }
  ngOnInit() {
  
    

  }


  delete() {
    const id: string = this.route.snapshot.params['id'];
    if(id != '' || id != null) {
      this.moviseServices.deleteMovie(id).subscribe(resp => {
        console.log(id);
        this.router.navigate(['movies']);
      },
        error => {
          alert(error['error']);
        });
      alert('form submitted');
    } 
  }

}


