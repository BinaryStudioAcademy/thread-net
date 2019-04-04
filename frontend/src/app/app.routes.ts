import { Routes } from '@angular/router';
import { AuthGuard } from './guards/auth.guard';
import { HomeComponent } from './components/home/home.component';

export const AppRoutes: Routes = [{ path: '', component: HomeComponent, canActivateChild: [AuthGuard] }, { path: '**', component: HomeComponent }];
