import { Component, OnInit, OnDestroy } from '@angular/core';
import { DialogType } from 'src/app/models/common/auth-dialog-type';
import { MatDialog, MatSnackBar } from '@angular/material';
import { User } from 'src/app/models/user';
import { AuthDialogComponent } from '../auth-dialog-module/auth-dialog.component';
import { Subscription } from 'rxjs';
import { AuthenticationService } from 'src/app/services/auth.service';
import { EventService } from 'src/app/services/event.service';
import { UserService } from 'src/app/services/user.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.sass']
})
export class HomeComponent implements OnInit, OnDestroy {
    public dialogType = DialogType;
    public isSignedIn = false;
    public authorizedUser: User;
    public subscription = new Subscription();

    constructor(
        private dialog: MatDialog,
        private snackBar: MatSnackBar,
        private authService: AuthenticationService,
        private eventService: EventService,
        private userService: UserService,
        private router: Router
    ) {}

    public ngOnInit() {
        this.getUser();

        this.eventService.userChangedEvent$.subscribe(() => {
            this.authService.getUser().subscribe((user) => (this.authorizedUser = this.userService.copyUser(user)));
        });
    }

    public ngOnDestroy() {
        this.subscription.unsubscribe();
    }

    public logout() {
        this.authService.logout();
        this.authorizedUser = undefined;
        this.router.navigate(['/']);
    }

    public openAuthDialog(type: DialogType) {
        const dialog = this.dialog.open(AuthDialogComponent, {
            data: { dialogType: type },
            minWidth: 300,
            autoFocus: true,
            backdropClass: 'dialog-backdrop',
            position: {
                top: '0'
            }
        });

        dialog.afterClosed().subscribe((result: User) => {
            if (result) {
                this.authorizedUser = result;
            }
        });
    }

    private getUser() {
        if (!this.authService.areTokensExist()) {
            return;
        }

        this.subscription.add(
            this.authService.getUser().subscribe(
                (user) => {
                    this.authorizedUser = this.userService.copyUser(user);
                },
                (error) => this.snackBar.open(error, '', { duration: 3000, panelClass: 'error-snack-bar' })
            )
        );
    }
}
