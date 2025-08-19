import { Injectable } from '@angular/core';

@Injectable({ providedIn: 'root' })
export class AuthService {
  // Mock login: accepts any username/password and returns a fake token
  login(username: string, password: string) {
    // in real app, call backend API
    const token = btoa(JSON.stringify({ username, exp: Date.now() + 1000 * 60 * 60 }));
    localStorage.setItem('token', token);
    return true;
  }
  logout() {
    localStorage.removeItem('token');
  }
  isAuthenticated(): boolean {
    return !!localStorage.getItem('token');
  }
  getUser(): string | null {
    const t = localStorage.getItem('token');
    if (!t) return null;
    try { return JSON.parse(atob(t)).username; } catch { return null; }
  }
}
