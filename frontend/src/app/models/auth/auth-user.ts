import { User } from '../../models/user';
import { AccessTokenDto } from '../../models/token/access-token-dto';

export interface AuthUser {
    user: User;
    token: AccessTokenDto;
}
