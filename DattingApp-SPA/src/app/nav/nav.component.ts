import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent {
  model: any = {};

  constructor(public authService: AuthService, private alertify: AlertifyService, private router: Router) { }

  // tslint:disable-next-line: use-lifecycle-interface
  ngOnInit() {
  }

  Login() {
    this.authService.login(this.model).subscribe(next => {
      this.alertify.success('Login realizado com sucesso');
    }, error => {
      this.alertify.error(error);
    }, () => {
      this.router.navigate(['/members']);
    }
    );
  }

  LoggedIn() {
    return this.authService.loggedIn();
  }

  LogOut() {
    localStorage.removeItem('token');
    this.alertify.messsage('LoggedOut');
    this.router.navigate(['/home']);
  }

}
