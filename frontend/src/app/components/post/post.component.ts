import { Component, OnInit, Input, OnDestroy } from '@angular/core';
import { Post } from 'src/app/models/post/post';
import { AuthenticationService } from 'src/app/services/auth.service';
import { AuthDialogService } from 'src/app/services/auth-dialog.service';
import { Subscription } from 'rxjs';
import { DialogType } from 'src/app/models/common/auth-dialog-type';
import { LikeService } from 'src/app/services/like.service';
import { NewComment } from 'src/app/models/comment/new-comment';
import { CommentService } from 'src/app/services/comment.service';
import { User } from 'src/app/models/user';
import { MatSnackBar } from '@angular/material';
import { Comment } from 'src/app/models/comment/comment';

@Component({
    selector: 'app-post',
    templateUrl: './post.component.html',
    styleUrls: ['./post.component.sass']
})
export class PostComponent implements OnInit, OnDestroy {
    @Input() public post: Post;
    @Input() public currentUser: User;

    public showComments = false;
    public subscription = new Subscription();
    public newComment = new NewComment();

    public constructor(
        private authService: AuthenticationService,
        private authDialogService: AuthDialogService,
        private likeService: LikeService,
        private commentService: CommentService,
        private snackBar: MatSnackBar
    ) {}

    public ngOnInit() {}

    public ngOnDestroy = () => this.subscription.unsubscribe();

    public toggleComments() {
        this.subscription.add(
            this.authService.getUser().subscribe(
                (user) => {
                    if (user && this.post) {
                        this.showComments = !this.showComments;
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

    public sendComment() {
        this.newComment.authorId = this.currentUser.id;
        this.newComment.postId = this.post.id;

        this.subscription.add(
            this.commentService.createComment(this.newComment).subscribe(
                (resp) => {
                    if (resp) {
                        this.post.comments = this.sortCommentArray(this.post.comments.concat(resp.body));
                        this.newComment.body = undefined;
                    }
                },
                (error) => this.snackBar.open(error, '', { duration: 3000, panelClass: 'error-snack-bar' })
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

    private sortCommentArray = (array: Comment[]): Comment[] => array.sort((a, b) => +new Date(b.createdAt) - +new Date(a.createdAt));
}
