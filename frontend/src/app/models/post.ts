import { User } from './user';
import { Comment } from './comment';

export class Post {
    public id: number;
    public createdAt: Date;
    public author: User;
    public previewImage: string;
    public body: string;
    public comments: Comment[];
}
