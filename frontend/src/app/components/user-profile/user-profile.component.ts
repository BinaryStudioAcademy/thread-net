import { Component, OnInit, Input, OnDestroy } from '@angular/core';
import { User } from 'src/app/models/user';
import { Location } from '@angular/common';
import { Subject } from 'rxjs';
import { UserService } from 'src/app/services/user.service';
import { AuthenticationService } from 'src/app/services/auth.service';
import { ImgurService } from 'src/app/services/imgur.service';
import { switchMap, takeUntil } from 'rxjs/operators';
import { SnackBarService } from 'src/app/services/snack-bar.service';

@Component({
    selector: 'app-user-profile',
    templateUrl: './user-profile.component.html',
    styleUrls: ['./user-profile.component.sass']
})
export class UserProfileComponent implements OnInit, OnDestroy {
    public user = {} as User;
    public loading = false;
    public imageFile: File;

    private unsubscribe$ = new Subject<void>();

    constructor(
        private location: Location,
        private userService: UserService,
        private snackBarService: SnackBarService,
        private authService: AuthenticationService,
        private imgurService: ImgurService
    ) {}

    public ngOnInit() {
        this.authService
            .getUser()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((user) => (this.user = this.userService.copyUser(user)), (error) => this.snackBarService.showErrorMessage(error));
    }

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    public saveNewInfo() {
        const userSubscription = !this.imageFile
            ? this.userService.updateUser(this.user)
            : this.imgurService.uploadToImgur(this.imageFile, 'title').pipe(
                  switchMap((imageData) => {
                      this.user.avatar = imageData.body.data.link;
                      return this.userService.updateUser(this.user);
                  })
              );

        this.loading = true;

        userSubscription.pipe(takeUntil(this.unsubscribe$)).subscribe(
            () => {
                this.authService.setUser(this.user);
                this.snackBarService.showUsualMessage('Successfully updated');
                this.loading = false;
            },
            (error) => this.snackBarService.showErrorMessage(error)
        );
    }

    public handleFileInput(target: any) {
        this.imageFile = target.files[0];

        if (!this.imageFile) {
            target.value = '';
            return;
        }

        if (this.imageFile.size / 1000000 > 5) {
            this.snackBarService.showErrorMessage(`Image can't be heavier than ~5MB`);
            target.value = '';
            return;
        }

        const reader = new FileReader();
        reader.addEventListener('load', () => (this.user.avatar = reader.result as string));
        reader.readAsDataURL(this.imageFile);
    }

    public goBack = () => this.location.back();
}
