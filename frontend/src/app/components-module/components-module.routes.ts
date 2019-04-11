import { Routes } from '@angular/router';
import { MainThreadComponent } from './main-thread/main-thread.component';
import { UserProfileComponent } from './user-profile/user-profile.component';

export const ComponentsModuleRoutes: Routes = [
    { path: '', component: MainThreadComponent, pathMatch: 'full' },
    { path: 'thread', component: MainThreadComponent, pathMatch: 'full' },
    { path: 'profile', component: UserProfileComponent, pathMatch: 'full' },
    { path: '**', redirectTo: '' }
];
