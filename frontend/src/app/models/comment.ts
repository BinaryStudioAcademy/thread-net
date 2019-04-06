import { User } from './user';
import { Post } from './post';

export class Comment {
    public user: User;
    public post: Post;
    public body: string;
}
