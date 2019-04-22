import { User } from 'src/app/models/user';
import { AccessTokenDto } from 'src/app/models/token/access-token-dto';

export class AuthUser {
    public user: User;
    public token: AccessTokenDto;
}
