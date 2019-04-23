import { Component, OnInit, Input } from '@angular/core';
import { Post } from 'src/app/models/post';
import { AuthenticationService } from 'src/app/services/auth.service';
import { AuthDialogService } from 'src/app/services/auth-dialog.service';
import { Subscription } from 'rxjs';
import { DialogType } from 'src/app/models/common/auth-dialog-type';
import { PostService } from 'src/app/services/post.service';
import { NewReaction } from 'src/app/models/reactions/newReaction';
import { LikeService } from 'src/app/services/like.service';

@Component({
    selector: 'app-post',
    templateUrl: './post.component.html',
    styleUrls: ['./post.component.sass']
})
export class PostComponent implements OnInit {
    @Input()
    public post: Post;
    public showComments = false;
    public subscription = new Subscription();

    public constructor(
        private authService: AuthenticationService,
        private authDialogService: AuthDialogService,
        private postService: PostService,
        private likeService: LikeService
    ) {}

    public ngOnInit() {}

    public toggleComments() {
        this.subscription.add(
            this.authService.getUser().subscribe(
                (user) => {
                    if (user) {
                        if (this.post && this.post.comments.length !== 0) {
                            this.showComments = !this.showComments;
                        }
                    }
                },
                (error) => this.openAuthDialog()
            )
        );
    }

    public likePost() {
        this.subscription.add(
            this.authService.getUser().subscribe(
                (userResp) => {
                    if (userResp) {
                        this.subscription.add(
                            this.likeService.likePost(this.post, userResp).subscribe((post) => {
                                this.post = post;
                            })
                        );
                    }
                },
                (error) => this.openAuthDialog()
            )
        );
    }

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
}
