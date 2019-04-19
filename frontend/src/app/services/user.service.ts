import { Injectable } from '@angular/core';
import { HttpInternalService } from 'src/app/services/http-internal.service';
import { User } from 'src/app/models/user';

@Injectable()
export class UserService {
    public routePrefix = '/api/users';

    constructor(private httpService: HttpInternalService) {}

    public getUserFromToken() {
        return this.httpService.getFullRequest<User>(`${this.routePrefix}/fromToken`);
    }

    public getUserById(userId: number) {
        return this.httpService.getFullRequest<User>(`${this.routePrefix}`, { id: userId });
    }

    public updateUser(user: User) {
        return this.httpService.putFullRequest<User>(`${this.routePrefix}`, user);
    }

    public copyUser(user: User) {
        return {
            avatar: user.avatar,
            email: user.email,
            userName: user.userName,
            id: user.id
        };
    }
}
