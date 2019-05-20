import { Component, Input, OnDestroy } from '@angular/core';
import { Post } from 'src/app/models/post/post';
import { AuthenticationService } from 'src/app/services/auth.service';
import { AuthDialogService } from 'src/app/services/auth-dialog.service';
import { Subscription, empty, Observable } from 'rxjs';
import { DialogType } from 'src/app/models/common/auth-dialog-type';
import { LikeService } from 'src/app/services/like.service';
import { NewComment } from 'src/app/models/comment/new-comment';
import { CommentService } from 'src/app/services/comment.service';
import { User } from 'src/app/models/user';
import { MatSnackBar } from '@angular/material';
import { Comment } from 'src/app/models/comment/comment';
import { catchError, switchMap } from 'rxjs/operators';

@Component({
    selector: 'app-post',
    templateUrl: './post.component.html',
    styleUrls: ['./post.component.sass']
})
export class PostComponent implements OnDestroy {
    @Input() public post: Post;
    @Input() public currentUser: User;

    public showComments = false;
    public subscription = new Subscription();
    public newComment = {} as NewComment;

    public constructor(
        private authService: AuthenticationService,
        private authDialogService: AuthDialogService,
        private likeService: LikeService,
        private commentService: CommentService,
        private snackBar: MatSnackBar
    ) {}

    public ngOnDestroy() {
        this.subscription.unsubscribe();
    }

    public toggleComments() {
        this.subscription.add(
            this.catchError(this.authService.getUser()).subscribe((user) => {
                if (user && this.post) {
                    this.showComments = !this.showComments;
                }
            })
        );
    }

    public likePost() {
        this.subscription.add(
            this.catchError(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => {
                        return this.likeService.likePost(this.post, userResp);
                    })
                )
                .subscribe((post) => {
                    this.post = post;
                })
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
        this.authDialogService.openAuthDialog(DialogType.SignIn);
    }

    private catchError(obs: Observable<User>) {
        return obs.pipe(
            catchError(() => {
                this.openAuthDialog();

                return empty();
            })
        );
    }

    private sortCommentArray(array: Comment[]): Comment[] {
        return array.sort((a, b) => +new Date(b.createdAt) - +new Date(a.createdAt));
    }
}
