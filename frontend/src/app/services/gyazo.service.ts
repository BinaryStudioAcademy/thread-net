import { Injectable } from '@angular/core';
import { HttpInternalService } from './http-internal.service';
import { environment } from 'src/environments/environment';
import { GyazoUpload } from '../models/gyazo';

@Injectable({ providedIn: 'root' })
export class GyazoService {
    constructor(private httpService: HttpInternalService) { }

    public uploadImage(image: Blob) {
        const data = new FormData();
        data.append('imagedata', image);

        return this.httpService.postRequest<GyazoUpload>(this.buildUrl('https://upload.gyazo.com/api/upload'), data);
    }

    public deleteImage(imageId: string) {
        return this.httpService.deleteRequest(this.buildUrl(`https://api.gyazo.com/api/images/${imageId}`));
    }

    private buildUrl(url: string) {
        return `${url}?access_token=${environment.gyazoAccessToken}`;
    }
}
