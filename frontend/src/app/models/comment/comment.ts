import { User } from '../user';
import { Reaction } from '../reactions/reaction';

export class Comment {
    public id: number;
    public createdAt: Date;
    public author: User;
    public body: string;
    public reactions: Reaction[];
}
