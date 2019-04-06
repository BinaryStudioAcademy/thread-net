import { Routes } from '@angular/router';
import { AuthGuard } from './guards/auth.guard';
import { MainThreadComponent } from './components/main-thread/main-thread.component';

export const AppRoutes: Routes = [
    { path: '', component: MainThreadComponent, pathMatch: 'full' },
    { path: 'thread', component: MainThreadComponent, pathMatch: 'full' },
    { path: '**', redirectTo: '' }
];
