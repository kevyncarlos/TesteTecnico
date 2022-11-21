import { HttpClient } from '@angular/common/http';
import { Injectable } from "@angular/core";
import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators'
import { Client } from '../Models/client';
import { ResponseModel } from '../Models/responseModel';

@Injectable()
export class ClientService {
    httpClient: HttpClient;

    constructor(httpClient: HttpClient) {
        this.httpClient = httpClient;
    }

    getAll() : Observable<Client[]> {
        return this.httpClient.get<ResponseModel<Client[]>>('/client')
            .pipe(map(x => x.data));
    }

    getById(id: number) : Observable<Client> {
        return this.httpClient.get<ResponseModel<Client>>(`/client/${id}`)
        .pipe(map(x => x.data));
    }

    post(client: Client) : Observable<Client> {
        return this.httpClient.post<ResponseModel<Client>>('/client', client)
        .pipe(map(x => x.data));
    }

    put(client: Client) : Observable<Client> {
        return this.httpClient.put<ResponseModel<Client>>('/client', client)
        .pipe(map(x => x.data));
    }

    delete(id: number) : Observable<boolean> {
        return this.httpClient.delete<ResponseModel<boolean>>(`client/${id}`)
            .pipe(map(x => x.data));
    }
}