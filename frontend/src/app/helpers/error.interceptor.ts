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
                    // doesn't work, need to check, there is no such header 'Token-Expired'
                    if (response.headers.has('Token-Expired')) {
                        this.authService.refreshTokens();
                        return next.handle(req);
                    }

                    if (response.error) {
                        if (response.error.code === ErrorCode.InvalidToken && !this.authService.areTokensExist()) {
                            return throwError(response.error.error);
                        }
                        if (response.error.code === ErrorCode.ExpiredRefreshToken) {
                            this.router.navigate(['/']);
                            this.authService.logout();
                            return throwError(response.error.error);
                        }
                    }
                }

                console.log(response);
                const error = response.error
                    ? response.error.error || response.error.message
                    : response.message || `${response.status} ${response.statusText}`;

                return throwError(error);
            })
        );
    }
}
