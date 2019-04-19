export class UserLoginDto {
    public email: string;
    public password: string;

    public constructor(email: string, passwrod: string) {
        this.email = email;
        this.password = passwrod;
    }
}
