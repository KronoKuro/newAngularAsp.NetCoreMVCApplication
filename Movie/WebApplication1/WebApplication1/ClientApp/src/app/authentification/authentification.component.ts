import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { AuthServices } from './auth.services';
import { Router } from '@angular/router';


@Component({
  selector: 'app-auth',
  templateUrl: './authentification.component.html',
  //styleUrls: ['./authentification.component.css']
})
export class AuthentificationComponent implements  OnInit {

  loginForm: FormGroup;

  constructor(private authService: AuthServices, private router: Router) {
    this.loginForm = new FormGroup({
      'Login': new FormControl('', Validators.required),
      'Password': new FormControl('', Validators.required)
    });
  }

  login() {
    this.authService.login(this.loginForm.getRawValue()).subscribe(resp => {
      localStorage.setItem('access_token', resp['access_token']);
      localStorage.setItem('access_token', resp['access_token']);
      localStorage.setItem('user_name', resp['user_name']);
      localStorage.setItem('admin', resp['admin']);
      localStorage.setItem('id', resp['id']);
      console.log(resp['access_token']);
      console.log(resp['id']);
      debugger;
      if (resp['admin'] != true) {
        this.router.navigate(['home']);
      } else {
        this.router.navigate(['admin']);
      }
    },
    error => {
        alert(error['error']);
    });
  }

  ngOnInit() {

  }
}
