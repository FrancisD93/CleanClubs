import { Injectable } from '@angular/core';
import { auth } from 'firebase/app';
import { AngularFireAuth } from '@angular/fire/auth';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class AuthService {
    userData: any;
    public signedIn: Observable<any>;

    constructor(
        private router: Router,
        public afAuth: AngularFireAuth // Inject Firebase auth service
    ) {
        this.afAuth.authState.subscribe((user) => {
            if (user) {
                this.userData = user;
                localStorage.setItem('user', JSON.stringify(this.userData));
                JSON.parse(localStorage.getItem('user'));
            } else {
                localStorage.setItem('user', null);
                JSON.parse(localStorage.getItem('user'));
            }
        });

        this.signedIn = new Observable((subscriber) => {
            this.afAuth.onAuthStateChanged(subscriber);
        });
    }

    // Sign in with Google
    GoogleAuth() {
        return this.AuthLogin(new auth.GoogleAuthProvider());
    }

    // Auth logic to run auth providers
    AuthLogin(provider) {
        return this.afAuth
            .signInWithPopup(provider)
            .then((result) => {
                console.log('You have been successfully logged in!');
            })
            .catch((error) => {
                console.log(error);
            });
    }

    async signOut() {
        localStorage.removeItem('user');
        await this.afAuth.signOut();
        this.router.navigate(['/']);
    }

    /**
     * Support checks for if the user was logged in
     */
    get isLoggedIn(): boolean {
        const user = JSON.parse(localStorage.getItem('user'));
        return user !== null ? true : false;
    }
}
