import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class AuthServices {
  
  constructor(private  http: HttpClient) {  }

  login(data: any) {
    return this.http.post('api/token', data);
  }
  

  checkAcess() {
    return this.http.get<boolean>('api/checktoken');
  }

  register(data: any) {
    return this.http.post('api/register', data);
  }

}
