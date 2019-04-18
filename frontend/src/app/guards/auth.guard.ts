import { Injectable } from '@angular/core';
import { CanActivate, CanActivateChild, Router, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';

@Injectable({ providedIn: 'root' })
export class AuthGuard implements CanActivateChild, CanActivate {
    constructor(private router: Router) {}

    public canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        return this.checkForActivation(state);
    }

    public canActivateChild(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        return this.checkForActivation(state);
    }

    private checkForActivation(state: RouterStateSnapshot) {
        if (localStorage.getItem('accessToken') && localStorage.getItem('refreshToken')) {
            return true;
        }

        this.router.navigate(['/']);

        return false;
    }
}
