import { Injectable } from '@angular/core';
import { HttpEvent, HttpInterceptor, HttpHandler, HttpRequest, HttpResponse, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError, empty } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Router } from '@angular/router';
import { AuthenticationService } from '../services/auth.service';
import { ErrorCode } from '../models/common/error-code';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {
    constructor(private router: Router, private authService: AuthenticationService) {}

    public intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        return next.handle(req).pipe(
            catchError((response: HttpErrorResponse) => {
                if (response.status === 401) {
                    if (response.error) {
                        if (response.error.code === ErrorCode.InvalidToken || response.error.code === ErrorCode.ExpiredRefreshToken) {
                            this.router.navigate(['/']);
                            this.authService.logout();
                            throwError(response.error.error);
                        }
                    }

                    if (response.headers.has('Token-Expired')) {
                        this.authService.refreshTokens();
                        return next.handle(req);
                    }
                }

                console.log(response);
                const error = response.error ? response.error.error : response.message || `${response.status} ${response.statusText}`;

                return throwError(error);
            })
        );
    }
}
