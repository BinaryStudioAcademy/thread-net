import { Injectable } from '@angular/core';
import { HttpEvent, HttpInterceptor, HttpHandler, HttpRequest } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {
    public intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        const accessToken = JSON.parse(localStorage.getItem('accessToken'));

        if (accessToken && !req.url.includes('gyazo.com')) {
            req = req.clone({ setHeaders: { Authorization: `Bearer ${accessToken}` } });
        }

        return next.handle(req);
    }
}
