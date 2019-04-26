import { Component, OnInit, Input, OnDestroy } from '@angular/core';
import { Comment } from 'src/app/models/comment/comment';

@Component({
    selector: 'app-comment',
    templateUrl: './comment.component.html',
    styleUrls: ['./comment.component.sass']
})
export class CommentComponent implements OnInit {
    @Input() public comment: Comment;

    public constructor() {}

    public ngOnInit() {}

    public getCommentDate(date: Date) {
        const createdAt = new Date(date);
        const currentDate = new Date();
        const monthNames = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];

        const days = currentDate.getDate() - createdAt.getDate();
        const hours = currentDate.getHours() - createdAt.getHours();
        const minutes = currentDate.getMinutes() - createdAt.getMinutes();

        if (currentDate > createdAt && days === 0 && hours < 24) {
            if (minutes < 60) {
                return `${minutes} minutes ago`;
            }
            return `${hours} hours ago`;
        }

        return `${createdAt.getDate()} ${monthNames[createdAt.getMonth()]}`;
    }
}
