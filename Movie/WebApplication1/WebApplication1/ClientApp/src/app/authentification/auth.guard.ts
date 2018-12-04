import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from "@angular/router";
import { AuthServices } from "./auth.services";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import * as decode from 'jwt-decode';



@Injectable()
export class AuthGuard implements CanActivate {

  constructor(public authService: AuthServices, public router: Router) { }

  canActivate(router: ActivatedRouteSnapshot): boolean {
    const expectedRole = router.data.expectedRole;
    const token = localStorage.getItem('access_token');
    if(token != null){
    const tokenPayLoad = decode(token);
    if (!this.authService.checkAcess() || tokenPayLoad.role !== expectedRole) {
      this.router.navigate(['login']);
      return false;
    }
    return true;
    }
    else{
      this.router.navigate(['login']);
    }
  }

  IsAdmin() {
    const token = localStorage.getItem('access_token');
    if (token != null) {
      const tokenPayLoad = decode(token);
      if (tokenPayLoad.role === "Admin") {
        return true;
      }
      else {
        return false;
      }
    }
    return false;
  }

}
