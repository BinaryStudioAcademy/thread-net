import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { MainThreadComponent } from './main-thread/main-thread.component';
import { AuthDialogComponent } from './auth-dialog/auth-dialog.component';
import { PostComponent } from './post/post.component';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialComponentsModule } from '../material-components-module/material-components.module';
import { RouterModule } from '@angular/router';
import { ComponentsModuleRoutes } from './components-module.routes';
import { FormsModule } from '@angular/forms';

@NgModule({
    declarations: [HomeComponent, MainThreadComponent, AuthDialogComponent, PostComponent, UserProfileComponent],
    imports: [
        CommonModule,
        FormsModule,
        RouterModule.forRoot(ComponentsModuleRoutes),
        BrowserModule,
        BrowserAnimationsModule,
        MaterialComponentsModule
    ],
    exports: [HomeComponent],
    providers: [],
    entryComponents: [AuthDialogComponent]
})
export class ComponentsModule {}
