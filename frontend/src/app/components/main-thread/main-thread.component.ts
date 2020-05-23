import { Component, OnInit, OnDestroy } from "@angular/core";
import { Post } from "../../models/post/post";
import { User } from "../../models/user";
import { Subject } from "rxjs";
import { MatSlideToggleChange } from "@angular/material/slide-toggle";
import { AuthenticationService } from "../../services/auth.service";
import { PostService } from "../../services/post.service";
import { AuthDialogService } from "../../services/auth-dialog.service";
import { DialogType } from "../../models/common/auth-dialog-type";
import { EventService } from "../../services/event.service";
import { ImgurService } from "../../services/imgur.service";
import { NewPost } from "../../models/post/new-post";
import { switchMap, takeUntil } from "rxjs/operators";
import { HubConnectionBuilder, HubConnection } from "@aspnet/signalr";
import { SnackBarService } from "../../services/snack-bar.service";

@Component({
  selector: "app-main-thread",
  templateUrl: "./main-thread.component.html",
  styleUrls: ["./main-thread.component.sass"],
})
export class MainThreadComponent implements OnInit, OnDestroy {
  public posts: Post[] = [];
  public cachedPosts: Post[] = [];
  public isOnlyMine = false;
  public isEditMode = false;

  public currentUser: User;
  public imageUrl: string;
  public imageFile: File;
  public post = {} as NewPost;
  public editablePost = {} as Post;
  public showPostContainer = false;
  public loading = false;
  public loadingPosts = false;

  public postHub: HubConnection;

  private unsubscribe$ = new Subject<void>();

  public constructor(
    private snackBarService: SnackBarService,
    private authService: AuthenticationService,
    private postService: PostService,
    private imgurService: ImgurService,
    private authDialogService: AuthDialogService,
    private eventService: EventService
  ) {}

  public ngOnDestroy() {
    this.unsubscribe$.next();
    this.unsubscribe$.complete();
    this.postHub.stop();
  }

  public ngOnInit() {
    this.registerHub();
    this.getPosts();
    this.getUser();

    this.eventService.userChangedEvent$
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe((user) => {
        this.currentUser = user;
        this.post.authorId = this.currentUser ? this.currentUser.id : undefined;
      });
  }

  public onDeletePost(postId: number) {
    this.loadingPosts = true;
    this.postService
      .deletePost(postId)
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe(
        (resp) => {
          this.loadingPosts = false;
          if (resp.ok) {
            this.posts = this.cachedPosts = this.cachedPosts.filter(
              (post) => post.id !== postId
            );

            if (this.isOnlyMine) {
              this.posts = this.showOnlyMine();
            }
          }
        },
        (err) => {
          this.snackBarService.showErrorMessage("Server responsed with error");
          this.loadingPosts = false;
        }
      );
  }

  public onEditPost(postId: number) {
    let post = this.cachedPosts.find((post) => post.id === postId);
    if (post !== null) {
      this.showPostContainer = true;
      this.isEditMode = true;
      this.imageUrl = post.previewImage;
      this.post.body = post.body;
      Object.assign(this.editablePost, post);
    }
  }

  public getPosts() {
    this.loadingPosts = true;
    this.postService
      .getPosts()
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe(
        (resp) => {
          this.loadingPosts = false;
          this.posts = this.cachedPosts = resp.body;
        },
        (error) => (this.loadingPosts = false)
      );
  }

  public sendPost() {
    if (this.isEditMode) {
      this.loading = true;
      this.editPost();
      return;
    }
    const postSubscription = !this.imageFile
      ? this.postService.createPost(this.post)
      : this.imgurService.uploadToImgur(this.imageFile, "title").pipe(
          switchMap((imageData) => {
            this.post.previewImage = imageData.body.data.link;
            return this.postService.createPost(this.post);
          })
        );

    this.loading = true;

    postSubscription.pipe(takeUntil(this.unsubscribe$)).subscribe(
      (respPost) => {
        this.addNewPost(respPost.body);
        this.removeImage();
        this.post.body = undefined;
        this.post.previewImage = undefined;
        this.loading = false;
      },
      (error) => this.snackBarService.showErrorMessage(error)
    );
  }

  public loadImage(target: any) {
    this.imageFile = target.files[0];

    if (!this.imageFile) {
      target.value = "";
      return;
    }

    if (this.imageFile.size / 1000000 > 5) {
      target.value = "";
      this.snackBarService.showErrorMessage(`Image can't be heavier than ~5MB`);
      return;
    }

    const reader = new FileReader();
    reader.addEventListener(
      "load",
      () => (this.imageUrl = reader.result as string)
    );
    reader.readAsDataURL(this.imageFile);
  }

  public removeImage() {
    this.imageUrl = undefined;
    this.imageFile = undefined;
    this.editablePost.previewImage = null;
  }

  public sliderChanged(event: MatSlideToggleChange) {
    if (event.checked) {
      this.isOnlyMine = true;
      this.posts = this.showOnlyMine();
    } else {
      this.isOnlyMine = false;
      this.posts = this.cachedPosts;
    }
  }

  public toggleNewPostContainer() {
    this.showPostContainer = !this.showPostContainer;
  }

  public openAuthDialog() {
    this.authDialogService.openAuthDialog(DialogType.SignIn);
  }

  public registerHub() {
    this.postHub = new HubConnectionBuilder()
      .withUrl("https://localhost:44344/notifications/post")
      .build();
    this.postHub
      .start()
      .catch((error) => this.snackBarService.showErrorMessage(error));

    this.postHub.on("NewPost", (newPost: Post) => {
      if (newPost) {
        this.addNewPost(newPost);
      }
    });
  }

  public addNewPost(newPost: Post) {
    if (!this.cachedPosts.some((x) => x.id === newPost.id)) {
      this.cachedPosts = this.sortPostArray(this.cachedPosts.concat(newPost));
      if (
        !this.isOnlyMine ||
        (this.isOnlyMine && newPost.author.id === this.currentUser.id)
      ) {
        this.posts = this.sortPostArray(this.posts.concat(newPost));
      }
    }
  }

  private updatePost(updatedPost: Post) {
    let oldPost = this.cachedPosts.find(post => post.id === updatedPost.id);
    let index = this.cachedPosts.indexOf(oldPost);
    this.cachedPosts.splice(index, 1, updatedPost);
    if(this.isOnlyMine) {
      this.posts = this.showOnlyMine();
    } else {
      this.posts = this.cachedPosts;
    }
  }

  private showOnlyMine() {
    return this.cachedPosts.filter((x) => x.author.id === this.currentUser.id);
  }

  private getUser() {
    this.authService
      .getUser()
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe((user) => (this.currentUser = user));
  }

  //after edit set to False
  private editPost() {
    this.editablePost.body = this.post.body;
    const postSubscription = !this.imageFile
      ? this.postService.updatePost(this.editablePost)
      : this.imgurService.uploadToImgur(this.imageFile, "title").pipe(
          switchMap((imageData) => {
            this.editablePost.previewImage = imageData.body.data.link;
            return this.postService.updatePost(this.editablePost);
          })
        );

    postSubscription.pipe(takeUntil(this.unsubscribe$)).subscribe(
      (resp) => {
        if(resp.ok) {
          this.updatePost(this.editablePost);
          this.removeImage();
          this.post.body = undefined;
          this.post.previewImage = undefined;
          this.editablePost = {} as Post;
          this.loading = false;
          this.isEditMode = false;
          this.showPostContainer = false;
          this.snackBarService.showUsualMessage("Post was updated");
        } else {
          this.snackBarService.showErrorMessage("Update error");
        }
      },
      (error) => this.snackBarService.showErrorMessage("Update error")
    );
  }

  private sortPostArray(array: Post[]): Post[] {
    return array.sort(
      (a, b) => +new Date(b.createdAt) - +new Date(a.createdAt)
    );
  }
}
