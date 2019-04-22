import { User } from './user';
import { Post } from './post';

export class Comment {
    public id: number;
    public createdAt: Date;
    public author: User;
    public body: string;
}
