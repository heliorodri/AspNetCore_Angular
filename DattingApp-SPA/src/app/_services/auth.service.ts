import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl = 'http://localhost:5000/api/auth/';

  constructor(private http: HttpClient) { }

  // model is an object that cointains username and password
  login(model: any) {
    return this.http.post(this.baseUrl + 'login', model)
      .pipe(
        map((Response: any) => {
          const user = Response;
          if (user) {
            localStorage.setItem('token', user.token);
          }
        })
      );
  }

  // model is an object that cointains username and password
  register(model: any) {
    return this.http.post(this.baseUrl + 'register', model);
  }
}