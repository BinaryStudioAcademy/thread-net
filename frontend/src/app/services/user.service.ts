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
}
