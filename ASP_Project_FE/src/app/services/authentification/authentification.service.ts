import { Injectable } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { ApiService } from '../api/api.service';

@Injectable({
  providedIn: 'root'
})
export class AuthentificationService {

  private readonly route = "/login";

  constructor(private readonly apiService: ApiService) { }

  login(loginBody: any): Observable<any> {
    return this.apiService.post<any>(`${this.route}/login`, loginBody).pipe(
      tap((response: any) => {
        if (response) {
          localStorage.setItem('token', response.token);
          localStorage.setItem('userId', response.id)
        }
      })
    )
  }

  createUser(createUserBody: any): Observable<any> {
    return this.apiService.post<any>(`${this.route}`, createUserBody);
  }

  isLoggedIn(): boolean {
    let token = localStorage.getItem('token');
    return token != null;
  }

  logout(): void {
    localStorage.removeItem('token');
    localStorage.removeItem('userId');
  }

}
