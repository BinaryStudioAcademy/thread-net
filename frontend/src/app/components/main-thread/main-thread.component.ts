import { Component, OnInit, OnDestroy } from '@angular/core';
import { Post } from 'src/app/models/post/post';
import { User } from 'src/app/models/user';
import { Subscription, Observable } from 'rxjs';
import { MatSnackBar, MatSlideToggleChange } from '@angular/material';
import { AuthenticationService } from 'src/app/services/auth.service';
import { PostService } from 'src/app/services/post.service';
import { AuthDialogService } from 'src/app/services/auth-dialog.service';
import { DialogType } from 'src/app/models/common/auth-dialog-type';
import { EventService } from 'src/app/services/event.service';
import { ImgurService } from 'src/app/services/imgur.service';
import { environment } from 'src/environments/environment';
import { NewPost } from 'src/app/models/post/new-post';
import { switchMap } from 'rxjs/operators';

@Component({
    selector: 'app-main-thread',
    templateUrl: './main-thread.component.html',
    styleUrls: ['./main-thread.component.sass']
})
export class MainThreadComponent implements OnInit, OnDestroy {
    public posts: Post[] = [];
    public cachedPosts: Post[] = [];
    public subscription = new Subscription();
    public currentUser: User;
    public imageUrl: string;
    public imageFile: File;
    public post = new NewPost();
    public showPostContainer = false;
    public loading = false;

    public constructor(
        private snackBar: MatSnackBar,
        private authService: AuthenticationService,
        private postService: PostService,
        private imgurService: ImgurService,
        private authDialogService: AuthDialogService,
        private eventService: EventService
    ) {}

    public ngOnInit() {
        this.getPosts();
        this.getUser();

        this.eventService.userChangedEvent$.subscribe((user) => {
            this.currentUser = user;
            this.post.authorId = this.currentUser ? this.currentUser.id : undefined;
        });
    }

    public ngOnDestroy = () => this.subscription.unsubscribe();

    public getPosts = () => this.subscription.add(this.postService.getPosts().subscribe((resp) => (this.posts = this.cachedPosts = resp.body)));

    public sliderChanged = (event: MatSlideToggleChange) =>
        event.checked ? (this.posts = this.posts.filter((x) => x.author.id === this.currentUser.id)) : (this.posts = this.cachedPosts);

    public toggleNewPostContainer = () => (this.showPostContainer = !this.showPostContainer);

    public openAuthDialog() {
        this.subscription.add(
            this.authDialogService
                .openAuthDialog(DialogType.SignIn)
                .afterClosed()
                .subscribe((resp) => {
                    if (resp) {
                        this.authService.setUser(resp);
                    }
                })
        );
    }

    public sendPost() {
        const postSubscription = !this.imageFile
            ? this.postService.createPost(this.post)
            : this.imgurService.uploadToImgur(environment.imgurClientId, this.imageFile, 'title').pipe(
                  switchMap((imageData) => {
                      this.post.previewImage = imageData.body.data.link;
                      return this.postService.createPost(this.post);
                  })
              );

        this.loading = true;
        this.subscription.add(
            postSubscription.subscribe(
                (respPost) => {
                    this.posts = this.posts.concat(respPost.body);
                    this.cachedPosts = this.cachedPosts.concat(respPost.body);
                    this.removeImage();
                    this.post = new NewPost();
                    this.loading = false;
                },
                (error) => this.snackBar.open(error, '', { duration: 3000, panelClass: 'error-snack-bar' })
            )
        );
    }

    public loadImage(target: any) {
        this.imageFile = target.files[0];

        if (!this.imageFile) {
            target.value = '';
            return;
        }

        if (this.imageFile.size / 1000000 > 5) {
            target.value = '';
            this.snackBar.open(`Image can't be heavier than ~5MB`, '', { duration: 3000, panelClass: 'error-snack-bar' });
            return;
        }

        const reader = new FileReader();
        reader.addEventListener('load', () => (this.imageUrl = reader.result as string));
        reader.readAsDataURL(this.imageFile);
    }

    public removeImage() {
        this.imageUrl = undefined;
        this.imageFile = undefined;
    }

    public getUser = () => this.subscription.add(this.authService.getUser().subscribe((user) => (this.currentUser = user)));
}
