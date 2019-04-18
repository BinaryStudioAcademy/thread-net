import { Component, OnInit, Input } from '@angular/core';
import { User } from 'src/app/models/user';
import { Location } from '@angular/common';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Subscription } from 'rxjs';
import { UserService } from 'src/app/services/user.service';

@Component({
    selector: 'app-user-profile',
    templateUrl: './user-profile.component.html',
    styleUrls: ['./user-profile.component.sass']
})
export class UserProfileComponent implements OnInit {
    public user = new User();
    public subscription = new Subscription();
    public newPassword: string;

    constructor(private location: Location, private route: ActivatedRoute, private userService: UserService) {}

    public ngOnInit() {
        this.subscription.add(
            this.userService.getUserFromToken().subscribe((resp) => {
                this.user = resp.body;
            })
        );
    }

    public goBack() {
        this.location.back();
    }
}
