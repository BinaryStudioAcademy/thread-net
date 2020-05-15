import { Injectable } from '@angular/core';
import { HttpInternalService } from '../services/http-internal.service';
import { User } from '../models/user';

@Injectable({ providedIn: 'root' })
export class UserService {
    public routePrefix = '/api/users';

    constructor(private httpService: HttpInternalService) {}

    public getUserFromToken() {
        return this.httpService.getFullRequest<User>(`${this.routePrefix}/fromToken`);
    }

    public getUserById(id: number) {
        return this.httpService.getFullRequest<User>(`${this.routePrefix}`, { id });
    }

    public updateUser(user: User) {
        return this.httpService.putFullRequest<User>(`${this.routePrefix}`, user);
    }

    public copyUser({ avatar, email, userName, id }: User) {
        return {
            avatar,
            email,
            userName,
            id
        };
    }
}
