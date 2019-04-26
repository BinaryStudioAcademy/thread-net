import { Injectable } from '@angular/core';
import { HttpEvent, HttpInterceptor, HttpHandler, HttpRequest } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {
    public intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        const accessToken = JSON.parse(localStorage.getItem('accessToken'));
        if (req.url.indexOf('https://api.imgur.com/') !== -1) {
            req = req.clone({ setHeaders: { Authorization: `Client-ID ${environment.imgurClientId}` } });
        } else if (accessToken) {
            req = req.clone({ setHeaders: { Authorization: `Bearer ${accessToken}` } });
        }

        return next.handle(req);
    }
}
