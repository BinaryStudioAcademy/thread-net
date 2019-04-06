import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { DialogType } from 'src/app/models/common/auth-dialog-type';

@Component({
    templateUrl: './auth-dialog.component.html',
    styleUrls: ['./auth-dialog.component.sass']
})
export class AuthDialogComponent implements OnInit {
    public title: string;
    public dialogType = DialogType;
    public user = new User();

    constructor(private dialogRef: MatDialogRef<AuthDialogComponent>, @Inject(MAT_DIALOG_DATA) public data: any) {}

    public ngOnInit() {}

    public close() {
        this.dialogRef.close(false);
    }

    public save() {
        this.dialogRef.close(true);
    }
}

// tslint:disable-next-line:max-classes-per-file
export class User {
    public email = '';
    public name = '';
    public password = '';
    public nickname = '';
}
