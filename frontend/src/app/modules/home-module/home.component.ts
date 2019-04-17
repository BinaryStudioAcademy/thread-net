import { Component, OnInit } from '@angular/core';
import { DialogType } from 'src/app/models/common/auth-dialog-type';
import { MatDialog } from '@angular/material';
import { AuthDialogComponent } from '../auth-dialog/auth-dialog.component';
import { User } from 'src/app/models/user';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.sass']
})
export class HomeComponent implements OnInit {
    public dialogType = DialogType;
    public isSignedIn = false;
    public authorizedUser: User;

    constructor(private dialog: MatDialog) {}

    public ngOnInit() {}

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
