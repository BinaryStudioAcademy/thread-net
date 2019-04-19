import { Component, OnInit, Input } from '@angular/core';
import { User } from 'src/app/models/user';
import { Location } from '@angular/common';
import { Subscription } from 'rxjs';
import { UserService } from 'src/app/services/user.service';
import { MatSnackBar } from '@angular/material';
import { AuthenticationService } from 'src/app/services/auth.service';
import { EventService } from 'src/app/services/event.service';

@Component({
    selector: 'app-user-profile',
    templateUrl: './user-profile.component.html',
    styleUrls: ['./user-profile.component.sass']
})
export class UserProfileComponent implements OnInit {
    public user = new User();
    public subscription = new Subscription();

    constructor(
        private location: Location,
        private userService: UserService,
        private snackBar: MatSnackBar,
        private authService: AuthenticationService
    ) {}

    public ngOnInit() {
        this.subscription.add(
            this.authService.getUser().subscribe(
                (user) => {
                    this.user = this.userService.copyUser(user);
                },
                (error) => this.snackBar.open(error, '', { duration: 3000, panelClass: 'error-snack-bar' })
            )
        );
    }

    public saveNewInfo() {
        this.subscription.add(
            this.userService.updateUser(this.user).subscribe(
                () => {
                    this.authService.setUser(this.user);
                    this.snackBar.open('Successfully updated', '', { duration: 3000, panelClass: 'usual-snack-bar' });
                },
                (error) => this.snackBar.open(error, '', { duration: 3000, panelClass: 'error-snack-bar' })
            )
        );
    }

    public goBack = () => this.location.back();
}
