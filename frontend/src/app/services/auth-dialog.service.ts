import { Injectable, OnDestroy } from '@angular/core';
import { DialogType } from '../models/common/auth-dialog-type';
import { AuthDialogComponent } from '../components/auth-dialog/auth-dialog.component';
import { User } from '../models/user';
import { MatDialog } from '@angular/material';
import { map } from 'rxjs/operators';
import { AuthenticationService } from './auth.service';
import { Subscription } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class AuthDialogService implements OnDestroy {
    private subscription: Subscription;

    public constructor(private dialog: MatDialog, private authService: AuthenticationService) {}

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

        this.subscription = dialog.afterClosed().subscribe((result: User) => {
            if (result) {
                this.authService.setUser(result);
            }
        });
    }

    public ngOnDestroy() {
        this.subscription.unsubscribe();
    }
}
