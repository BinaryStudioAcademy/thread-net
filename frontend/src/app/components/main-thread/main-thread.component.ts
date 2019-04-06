import { Component, OnInit } from '@angular/core';
import { Post } from 'src/app/models/post';
import { User } from 'src/app/models/user';
import { Image } from 'src/app/models/image';

@Component({
    selector: 'app-main-thread',
    templateUrl: './main-thread.component.html',
    styleUrls: ['./main-thread.component.sass']
})
export class MainThreadComponent implements OnInit {
    public mainUser: User = {
        email: 'avatar@test',
        password: '111',
        userName: 'Avatar',
        avatar: { url: 'https://cdn.shopify.com/s/files/1/0183/2727/products/LV_airbender_pin2.jpg?v=1552601810' }
    };

    public mainImage: Image = {
        url: 'https://cdn.pixabay.com/photo/2018/01/12/10/19/fantasy-3077928__340.jpg'
    };

    public posts: Post[] = [
        {
            user: this.mainUser,
            body: 'Lorem ipsum',
            preview: undefined
        },
        {
            user: this.mainUser,
            body: 'Lorem ipsum Lorem ipsum',
            preview: this.mainImage
        },
        {
            user: this.mainUser,
            body: 'Lorem ipsum Lorem ipsum Lorem ipsum',
            preview: undefined
        },
        {
            user: this.mainUser,
            body: 'Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum',
            preview: this.mainImage
        },
        {
            user: this.mainUser,
            body: 'Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum',
            preview: this.mainImage
        }
    ];

    constructor() {}

    ngOnInit() {}
}
