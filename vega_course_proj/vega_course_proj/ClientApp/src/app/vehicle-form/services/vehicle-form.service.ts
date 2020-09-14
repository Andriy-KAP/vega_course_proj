import { HttpClient } from '@angular/common/http';
import { Injectable } from "@angular/core";
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable()
export class VehicleFormService{
    constructor(private client: HttpClient){

    }

    public getMakes(): Observable<any[]>{
        return this.client.get('/api/makes').pipe(map((response: any[])=>{
            return response;
        }));
    }

    public getFeatures(): Observable<any[]>{
        return this.client.get('/api/features').pipe(map((response: any[])=>{
            return response;
        }))
    }
}