import { Routes } from '@angular/router';
import { AuthGuard } from './guards/auth.guard';
import { MainThreadComponent } from './modules/main-thread/main-thread.component';
import { UserProfileComponent } from './modules/user-profile/user-profile.component';

export const AppRoutes: Routes = [
    { path: '', component: MainThreadComponent, pathMatch: 'full' },
    { path: 'thread', component: MainThreadComponent, pathMatch: 'full' },
    { path: 'profile', component: UserProfileComponent, pathMatch: 'full', canActivate: [AuthGuard] },
    { path: '**', redirectTo: '' }
];
