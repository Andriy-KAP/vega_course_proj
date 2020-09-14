import { Component, OnInit } from "@angular/core";
import { VehicleFormService } from "./services/vehicle-form.service";

@Component({
    selector: 'vehicle-form',
    templateUrl: './vehicle-form.component.html',
    styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit{
    public makes: any;

    constructor(private service: VehicleFormService){

    }

    ngOnInit(): void {
        this.service.getMakes().subscribe((makes)=>{
            this.makes = makes;
            console.log('Makes: ', this.makes);
        });
        
    }
}