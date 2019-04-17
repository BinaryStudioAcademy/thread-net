import { HttpInternalService } from 'src/app/services/http-internal.service';
import { Injectable } from '@angular/core';
import { UserRegisterDto } from '../models/user-register-dto';
import { UserLoginDto } from '../models/user-login-dto';
import { map } from 'rxjs/operators';
import { AuthUser } from '../models/auth-user';
import { AccessTokenDto } from 'src/app/models/access-token-dto';
import { Observable } from 'rxjs';
import { HttpResponse } from '@angular/common/http';

@Injectable()
export class AuthApiService {
    public routePrefix = '/api';

    constructor(private httpService: HttpInternalService) {}

    public register(user: UserRegisterDto) {
        return this.handleAuthResponse(this.httpService.postFullRequest<AuthUser>(`${this.routePrefix}/register`, user));
    }

    public login(user: UserLoginDto) {
        return this.handleAuthResponse(this.httpService.postFullRequest<AuthUser>(`${this.routePrefix}/auth/login`, user));
    }

    private handleAuthResponse(observable: Observable<HttpResponse<AuthUser>>) {
        return observable.pipe(
            map((resp) => {
                this.setTokens(resp.body.token);
                return resp.body.user;
            })
        );
    }

    private setTokens(tokens: AccessTokenDto) {
        if (tokens && tokens.accessToken && tokens.refreshToken) {
            localStorage.setItem('accessToken', JSON.stringify(tokens.accessToken.token));
            localStorage.setItem('refreshToken', JSON.stringify(tokens.refreshToken));
        }
    }
}
