import { Injectable } from '@angular/core';
import { AuthenticationService } from './auth.service';
import { Post } from '../models/post';
import { NewReaction } from '../models/reactions/newReaction';
import { PostService } from './post.service';
import { User } from '../models/user';
import { map, catchError } from 'rxjs/operators';
import { of } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class LikeService {
    public constructor(private authService: AuthenticationService, private postService: PostService) {}

    public likePost(post: Post, currentUser: User) {
        const innerPost = post;

        const reaction: NewReaction = {
            entityId: innerPost.id,
            isLike: true,
            userId: currentUser.id
        };

        // update current array instantly
        let currentUserLike = innerPost.reactions.find((x) => x.user.id === currentUser.id);
        innerPost.reactions = currentUserLike
            ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
            : innerPost.reactions.concat({ isLike: true, user: currentUser });

        return this.postService.likePost(reaction).pipe(
            map((resp) => innerPost),
            catchError((error) => {
                // revert current array changes in case of any error
                currentUserLike = innerPost.reactions.find((x) => x.user.id === currentUser.id);
                innerPost.reactions = currentUserLike
                    ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
                    : innerPost.reactions.concat({ isLike: true, user: currentUser });

                return of(innerPost);
            })
        );
    }
}
