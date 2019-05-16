import { Injectable } from '@angular/core';

import { Subject } from 'rxjs';
import { User } from '../models/user';

// tslint:disable:member-ordering
@Injectable({ providedIn: 'root' })
export class EventService {
    private onUserChanged = new Subject<User>();
    public userChangedEvent$ = this.onUserChanged.asObservable();

    public userChanged(user: User) {
        this.onUserChanged.next(user);
    }
}
