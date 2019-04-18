import { Component, OnInit, Inject, OnDestroy } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA, MatSnackBar } from '@angular/material';
import { DialogType } from 'src/app/models/common/auth-dialog-type';
import { AuthApiService } from './services/auth-api.service';
import { UserRegisterDto } from './models/user-register-dto';
import { UserLoginDto } from './models/user-login-dto';
import { Subscription } from 'rxjs';

@Component({
    templateUrl: './auth-dialog.component.html',
    styleUrls: ['./auth-dialog.component.sass'],
    providers: [AuthApiService]
})
export class AuthDialogComponent implements OnInit, OnDestroy {
    public dialogType = DialogType;
    public userName: string;
    public password: string;
    public avatar: string;
    public email: string;

    public subscription = new Subscription();
    public hidePass = true;
    public title: string;

    constructor(
        private dialogRef: MatDialogRef<AuthDialogComponent>,
        @Inject(MAT_DIALOG_DATA) public data: any,
        private authApiService: AuthApiService,
        private snackBar: MatSnackBar
    ) {}

    public ngOnInit() {
        this.avatar = 'https://cdn.shopify.com/s/files/1/0183/2727/products/LV_airbender_pin2.jpg?v=1552601810';
        this.title = this.data.dialogType === DialogType.SignIn ? 'Sign In' : 'Sign Up';
    }

    public ngOnDestroy() {
        this.subscription.unsubscribe();
    }

    public close() {
        this.dialogRef.close(false);
    }

    public signIn() {
        this.subscription.add(
            this.authApiService.login(new UserLoginDto(this.email, this.password)).subscribe(
                (response) => {
                    this.dialogRef.close(response);
                },
                (error) => {
                    this.snackBar.open(error, '', { duration: 3000, panelClass: 'error-snack-bar' });
                }
            )
        );
    }

    public signUp() {
        this.subscription.add(
            this.authApiService.register(new UserRegisterDto(this.userName, this.password, this.email, this.avatar)).subscribe(
                (response) => {
                    this.dialogRef.close(response);
                },
                (error) => {
                    this.snackBar.open(error, '', { duration: 3000, panelClass: 'error-snack-bar' });
                }
            )
        );
    }
}
