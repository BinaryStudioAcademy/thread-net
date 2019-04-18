import { Component, OnInit, OnDestroy } from '@angular/core';
import { DialogType } from 'src/app/models/common/auth-dialog-type';
import { MatDialog, MatSnackBar } from '@angular/material';
import { User } from 'src/app/models/user';
import { AuthDialogComponent } from '../auth-dialog-module/auth-dialog.component';
import { Subscription } from 'rxjs';
import { UserService } from 'src/app/services/user.service';

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

    constructor(private dialog: MatDialog, private userService: UserService, private snackBar: MatSnackBar) {}

    public ngOnInit() {
        this.subscription.add(
            this.userService.getUserFromToken().subscribe(
                (resp) => {
                    if (resp) {
                        this.authorizedUser = resp.body;
                    }
                },
                (error) => this.snackBar.open(error, '', { duration: 3000, panelClass: 'error-snack-bar' })
            )
        );
    }

    public ngOnDestroy() {
        this.subscription.unsubscribe();
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
}
