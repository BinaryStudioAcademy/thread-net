import { Component, OnInit, Input, OnDestroy } from '@angular/core';
import { User } from 'src/app/models/user';
import { Location } from '@angular/common';
import { Subscription } from 'rxjs';
import { UserService } from 'src/app/services/user.service';
import { MatSnackBar } from '@angular/material';
import { AuthenticationService } from 'src/app/services/auth.service';
import { ImgurService } from 'src/app/services/imgur.service';
import { environment } from 'src/environments/environment';
import { switchMap } from 'rxjs/operators';

@Component({
    selector: 'app-user-profile',
    templateUrl: './user-profile.component.html',
    styleUrls: ['./user-profile.component.sass']
})
export class UserProfileComponent implements OnInit, OnDestroy {
    public user = {} as User;
    public subscription = new Subscription();
    public loading = false;
    public imageFile: File;

    constructor(
        private location: Location,
        private userService: UserService,
        private snackBar: MatSnackBar,
        private authService: AuthenticationService,
        private imgurService: ImgurService
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

    public ngOnDestroy() {
        this.subscription.unsubscribe();
    }

    public saveNewInfo() {
        const userSubscription = !this.imageFile
            ? this.userService.updateUser(this.user)
            : this.imgurService.uploadToImgur(environment.imgurClientId, this.imageFile, 'title').pipe(
                  switchMap((imageData) => {
                      this.user.avatar = imageData.body.data.link;
                      return this.userService.updateUser(this.user);
                  })
              );

        this.loading = true;
        this.subscription.add(
            userSubscription.subscribe(
                () => {
                    this.authService.setUser(this.user);
                    this.snackBar.open('Successfully updated', '', { duration: 3000, panelClass: 'usual-snack-bar' });
                    this.loading = false;
                },
                (error) => this.snackBar.open(error, '', { duration: 3000, panelClass: 'error-snack-bar' })
            )
        );
    }

    public handleFileInput(target: any) {
        this.imageFile = target.files[0];

        if (!this.imageFile) {
            target.value = '';
            return;
        }

        if (this.imageFile.size / 1000000 > 5) {
            this.snackBar.open(`Image can't be heavier than ~5MB`, '', { duration: 3000, panelClass: 'error-snack-bar' });
            target.value = '';
            return;
        }

        const reader = new FileReader();
        reader.addEventListener('load', () => (this.user.avatar = reader.result as string));
        reader.readAsDataURL(this.imageFile);
    }

    public goBack = () => this.location.back();
}
