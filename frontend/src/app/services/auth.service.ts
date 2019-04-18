import { Injectable } from '@angular/core';
import { HttpInternalService } from './http-internal.service';
import { AccessTokenDto } from '../models/access-token-dto';
import { map } from 'rxjs/operators';
import { User } from '../models/user';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
    public static isAuthenticated = false;
    public routePrefix = '/api/token';

    constructor(private httpService: HttpInternalService) {}

    public logout() {
        this.httpService.postFullRequest(`${this.routePrefix}/revoke`, { refreshToken: localStorage.getItem('refreshToken') });

        localStorage.removeItem('accessToken');
        localStorage.removeItem('refreshToken');
        AuthenticationService.isAuthenticated = false;
    }

    public refreshToken() {
        this.httpService
            .postFullRequest<AccessTokenDto>(`${this.routePrefix}/refresh`, {
                accessToken: localStorage.getItem('accessToken'),
                refreshToken: localStorage.getItem('refreshToken')
            })
            .pipe(
                map((resp) => {
                    localStorage.setItem('accessToken', JSON.stringify(resp.body.accessToken.token));
                    localStorage.setItem('refreshToken', JSON.stringify(resp.body.refreshToken));
                })
            );
    }
}
