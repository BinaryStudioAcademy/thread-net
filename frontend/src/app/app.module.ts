import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { JwtInterceptor } from './helpers/jwt.interceptor';
import { ErrorInterceptor } from './helpers/error.interceptor';
import { RouterModule } from '@angular/router';
import { AppRoutes } from './app.routes';
import { FormsModule } from '@angular/forms';
import { MainThreadComponent } from './modules/main-thread/main-thread.component';
import { PostComponent } from './modules/post/post.component';
import { MaterialComponentsModule } from './modules/common/material-components.module';
import { HomeComponent } from './modules/home/home.component';
import { UserProfileComponent } from './modules/user-profile/user-profile.component';
import { AuthDialogComponent } from './modules/auth-dialog-module/auth-dialog.component';
import { CommentComponent } from './modules/comment/comment.component';

@NgModule({
    declarations: [AppComponent, MainThreadComponent, PostComponent, HomeComponent, UserProfileComponent, AuthDialogComponent, CommentComponent],
    imports: [BrowserModule, BrowserAnimationsModule, HttpClientModule, MaterialComponentsModule, RouterModule.forRoot(AppRoutes), FormsModule],
    exports: [MaterialComponentsModule],
    providers: [
        { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
    ],
    entryComponents: [AuthDialogComponent],
    bootstrap: [AppComponent]
})
export class AppModule {}
