import { Injectable } from '@angular/core';

import { Subject } from 'rxjs';

// tslint:disable:member-ordering
@Injectable()
export class EventService {
    private onUserChanged = new Subject<void>();
    public userChangedEvent$ = this.onUserChanged.asObservable();

    public userChanged() {
        this.onUserChanged.next();
    }
}
