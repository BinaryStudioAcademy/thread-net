import { Injectable } from '@angular/core';
import { CanActivate, CanActivateChild, Router, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { AuthenticationService } from '../services/auth.service';

@Injectable({ providedIn: 'root' })
export class AuthGuard implements CanActivateChild, CanActivate {
    constructor(private router: Router, private authService: AuthenticationService) {}

    public canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        return this.checkForActivation(state);
    }

    public canActivateChild(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        return this.checkForActivation(state);
    }

    private checkForActivation(state: RouterStateSnapshot) {
        if (this.authService.areTokensExist()) {
            return true;
        }

        this.router.navigate(['/']);

        return false;
    }
}
