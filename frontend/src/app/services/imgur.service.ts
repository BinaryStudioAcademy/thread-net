import { Injectable } from '@angular/core';
import { Observable, of, Subscription, Subject } from 'rxjs';
import { environment } from 'src/environments/environment';
import { HttpInternalService } from './http-internal.service';
import { map, switchMap } from 'rxjs/operators';

@Injectable({ providedIn: 'root' })
export class ImgurService {
    constructor(private httpService: HttpInternalService) {}

    public uploadToImgur(image: Blob, title: string) {
        return this.imageDataToBase64(image).pipe(switchMap((imageBase64: string) => this.sendImgurRequest(imageBase64, title)));
    }

    public deleteFromImgur(imageHash: string) {
        return this.httpService.deleteFullRequest(`https://api.imgur.com/3/image/${imageHash}`);
    }

    private sendImgurRequest(imageBase64: string, imageTitle: string) {
        const body = {
            image: imageBase64,
            title: imageTitle,
            type: 'base64'
        };
        return this.httpService.postFullRequest<any>('https://api.imgur.com/3/image', body);
    }

    private imageDataToBase64(imageData: Blob) {
        const reader = new FileReader();
        const result = new Subject<string>();

        reader.addEventListener('load', () => result.next(this.arrayBufferToBase64(reader.result as ArrayBuffer)));
        reader.addEventListener('error', () => result.error('Error reading image data'));
        reader.readAsArrayBuffer(imageData);

        return result;
    }

    private arrayBufferToBase64(buffer: ArrayBuffer): string {
        let binary = '';
        const bytes = new Uint8Array(buffer);
        for (let i = 0; i < bytes.byteLength; ++i) {
            binary += String.fromCharCode(bytes[i]);
        }
        return btoa(binary);
    }
}
