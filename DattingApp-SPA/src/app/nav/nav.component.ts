import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(private authService: AuthService, private alertify: AlertifyService) { }

  ngOnInit() {
  }

  Login() {
    this.authService.login(this.model).subscribe(next => {
      this.alertify.success('Login realizado com sucesso');
    }, error => {
      this.alertify.error(error);
    });
  }

  LoggedIn() {
    const token = localStorage.getItem('token');
    return !!token;
  }

  LogOut() {
    localStorage.removeItem('token');
    this.alertify.messsage('LoggedOut');
  }

}
