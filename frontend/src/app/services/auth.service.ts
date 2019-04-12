import { Injectable } from '@angular/core';
import { HttpInternalService } from './http-internal.service';
import { Observable } from 'rxjs';
import { HttpResponse } from '@angular/common/http';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
    public static logout = () => localStorage.removeItem('currentUser');

    public static isAuthenticated = () => !!localStorage.getItem('currentUser');

    constructor(private httpService: HttpInternalService) {}

    public login(email: string, password: string): Observable<HttpResponse<string>> {
        return this.httpService.postFullRequest(`/api/login`, {
            email,
            password
        });
    }
}
