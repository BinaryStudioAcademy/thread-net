import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Comment } from '../../models/comment/comment';
import { User } from 'src/app/models/user';

@Component({
    selector: 'app-comment',
    templateUrl: './comment.component.html',
    styleUrls: ['./comment.component.sass']
})
export class CommentComponent {
    @Input() public comment: Comment;
    @Input() public currentUser: User;
    @Output() public deleteClick = new EventEmitter<number>();

    public deleteComment(commentId: number) {
        this.deleteClick.emit(commentId);
    }

    public isAuthor() {
        let currentUserId = this.currentUser.id;
        let commentUserId = this.comment.author.id;
        return currentUserId === commentUserId;
    }
}
