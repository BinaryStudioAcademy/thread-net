import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialComponentsModule } from './components/common/material-components.module';
import { HomeComponent } from './components/home/home.component';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtInterceptor } from './helpers/jwt.interceptor';
import { ErrorInterceptor } from './helpers/error.interceptor';
import { RouterModule } from '@angular/router';
import { AppRoutes } from './app.routes';
import { MainThreadComponent } from './components/main-thread/main-thread.component';
import { AuthDialogComponent } from './components/auth-dialog/auth-dialog.component';
import { PostComponent } from './components/post/post.component';
import { UserProfileComponent } from './components/user-profile/user-profile.component';
import { FormsModule } from '@angular/forms';

@NgModule({
    declarations: [AppComponent, HomeComponent, MainThreadComponent, AuthDialogComponent, PostComponent, UserProfileComponent],
    imports: [BrowserModule, BrowserAnimationsModule, MaterialComponentsModule, RouterModule.forRoot(AppRoutes), FormsModule],
    exports: [MaterialComponentsModule],
    providers: [
        { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
    ],
    entryComponents: [AuthDialogComponent],
    bootstrap: [AppComponent]
})
export class AppModule {}
