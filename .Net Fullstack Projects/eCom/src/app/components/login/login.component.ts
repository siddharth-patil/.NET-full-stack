import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../../services/auth.service';

@Component({ selector: 'app-login', templateUrl: './login.component.html' })
export class LoginComponent {
  username = '';
  password = '';
  error = '';
  constructor(private auth: AuthService, private router: Router) {}
  submit(){
    if (!this.username || !this.password) { this.error = 'Enter credentials'; return; }
    const ok = this.auth.login(this.username, this.password);
    if (ok) this.router.navigate(['/']);
    else this.error = 'Login failed';
  }
}
