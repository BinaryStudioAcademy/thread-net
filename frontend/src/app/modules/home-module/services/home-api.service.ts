import { Injectable } from '@angular/core';
import { HttpInternalService } from 'src/app/services/http-internal.service';

@Injectable()
export class HomeApiService {
    public routePrefix = '/api';

    constructor(private httpService: HttpInternalService) {}

    public getUser() {}