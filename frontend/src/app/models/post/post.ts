import { User } from '../user';
import { Comment } from '../comment/comment';
import { Reaction } from '../reactions/reaction';

export class Post {
    public id: number;
    public createdAt: Date;
    public author: User;
    public previewImage: string;
    public body: string;
    public comments: Comment[] = [];
    public reactions: Reaction[] = [];
}
