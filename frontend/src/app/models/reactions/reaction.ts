import { User } from '../user';

export interface Reaction {
    isLike: boolean;
    user: User;
}
