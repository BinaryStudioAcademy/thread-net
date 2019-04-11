import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { DialogType } from 'src/app/components-module/models/auth-dialog-type';
import { User } from 'src/app/components-module/models/user';

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
