import { HttpClient } from '@angular/common/http';
import { Injectable } from "@angular/core";
import { map } from 'rxjs/operators';
@Injectable()
export class VehicleFormService{
    constructor(private client: HttpClient){

    }

    public getMakes(){
        return this.client.get('/api/makes').map((response)=>{
            response.json();
        });
    }
}