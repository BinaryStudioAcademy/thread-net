import { Component, OnInit, Input } from '@angular/core';
import { Post } from 'src/app/components-module/models/post';

@Component({
    selector: 'app-post',
    templateUrl: './post.component.html',
    styleUrls: ['./post.component.sass']
})
export class PostComponent implements OnInit {
    @Input()
    public post: Post;

    constructor() {}

    public ngOnInit() {}
}
