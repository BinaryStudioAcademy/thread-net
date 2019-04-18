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
import { HttpInternalService } from './services/http-internal.service';
import { MainThreadComponent } from './modules/main-thread/main-thread.component';
import { PostComponent } from './modules/post/post.component';
import { AuthDialogModule } from './modules/auth-dialog-module/auth-dialog.module';
import { MaterialComponentsModule } from './modules/common/material-components.module';
import { AuthenticationService } from './services/auth.service';
import { HomeComponent } from './modules/home/home.component';
import { UserProfileComponent } from './modules/user-profile/user-profile.component';
import { UserService } from './services/user.service';

@NgModule({
    declarations: [AppComponent, MainThreadComponent, PostComponent, HomeComponent, UserProfileComponent],
    imports: [
        BrowserModule,
        BrowserAnimationsModule,
        HttpClientModule,
        AuthDialogModule,
        MaterialComponentsModule,
        RouterModule.forRoot(AppRoutes),
        FormsModule
    ],
    exports: [MaterialComponentsModule],
    providers: [
        HttpInternalService,
        AuthenticationService,
        UserService,
        { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
    ],
    bootstrap: [AppComponent]
})
export class AppModule {}
