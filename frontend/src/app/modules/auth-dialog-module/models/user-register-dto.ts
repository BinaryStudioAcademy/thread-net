export class UserRegisterDto {
    public userName: string;
    public password: string;
    public email: string;
    public avatar: string;

    constructor(userName: string, password: string, email: string, avatar: string) {
        this.avatar = avatar;
        this.email = email;
        this.password = password;
        this.userName = userName;
    }
}
