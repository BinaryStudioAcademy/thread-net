import { Component, OnInit, OnDestroy } from '@angular/core';
import { DialogType } from '../../models/common/auth-dialog-type';
import { User } from '../../models/user';
import { Subject } from 'rxjs';
import { AuthenticationService } from '../../services/auth.service';
import { EventService } from '../../services/event.service';
import { UserService } from '../../services/user.service';
import { Router } from '@angular/router';
import { AuthDialogService } from '../../services/auth-dialog.service';
import { takeUntil } from 'rxjs/operators';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.sass']
})
export class HomeComponent implements OnInit, OnDestroy {
    public dialogType = DialogType;
    public authorizedUser: User;
    private unsubscribe$ = new Subject<void>();

    constructor(
        private authDialogService: AuthDialogService,
        private authService: AuthenticationService,
        private eventService: EventService,
        private userService: UserService,
        private router: Router
    ) {}

    public ngOnInit() {
        this.getUser();

        this.eventService.userChangedEvent$
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((user) => (this.authorizedUser = user ? this.userService.copyUser(user) : undefined));
    }

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    public logout() {
        this.authService.logout();
        this.authorizedUser = undefined;
        this.router.navigate(['/']);
    }

    public openAuthDialog(type: DialogType) {
        this.authDialogService.openAuthDialog(type);
    }

    private getUser() {
        if (!this.authService.areTokensExist()) {
            return;
        }

        this.authService
            .getUser()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((user) => (this.authorizedUser = this.userService.copyUser(user)));
    }
}
