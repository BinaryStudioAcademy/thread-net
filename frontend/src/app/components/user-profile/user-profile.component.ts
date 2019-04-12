import { Component, OnInit, Input } from '@angular/core';
import { User } from 'src/app/models/user';
import { Location } from '@angular/common';

@Component({
    selector: 'app-user-profile',
    templateUrl: './user-profile.component.html',
    styleUrls: ['./user-profile.component.sass']
})
export class UserProfileComponent implements OnInit {
    public user: User = {
        email: 'avatar@test',
        password: '111',
        userName: 'Avatar',
        avatar: { url: 'https://cdn.shopify.com/s/files/1/0183/2727/products/LV_airbender_pin2.jpg?v=1552601810' }
    };

    constructor(private location: Location) {}

    public ngOnInit() {}

    public goBack() {
        this.location.back();
    }
}
