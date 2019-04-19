import { Component, OnInit, OnDestroy } from '@angular/core';
import { Post } from 'src/app/models/post';
import { User } from 'src/app/models/user';
import { Subscription } from 'rxjs';
import { MatSnackBar } from '@angular/material';
import { AuthenticationService } from 'src/app/services/auth.service';
import { PostService } from 'src/app/services/post.service';

@Component({
    selector: 'app-main-thread',
    templateUrl: './main-thread.component.html',
    styleUrls: ['./main-thread.component.sass']
})
export class MainThreadComponent implements OnInit, OnDestroy {
    public posts: Post[] = [];
    public subscription = new Subscription();

    public constructor(private snackBar: MatSnackBar, private authService: AuthenticationService, private postService: PostService) {}

    public ngOnInit() {
        this.getPosts();
    }

    public ngOnDestroy = () => this.subscription.unsubscribe();

    public getPosts() {
        this.subscription.add(
            this.postService.getPosts().subscribe((resp) => {
                if (resp) {
                    this.posts = resp.body;
                }
            })
        );
    }
}
