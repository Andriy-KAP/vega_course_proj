import { Component, OnInit } from "@angular/core";
import { VehicleFormService } from "./services/vehicle-form.service";

@Component({
    selector: 'vehicle-form',
    templateUrl: './vehicle-form.component.html',
    styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit{
    public makes: any[];
    public models: any[];
    public features: any[];
    public vehicle: { make: string };

    constructor(private vehicleService: VehicleFormService){

    }

    ngOnInit(): void {
        this.vehicleService.getMakes().subscribe((makes)=>{
            this.makes = makes;
        });
        this.vehicleService.getFeatures().subscribe((features)=>{
            this.features = features;
        });
        
    }

    public onMakeChange(): void{
        let selectedMake = this.makes.find(m=> m.Id == this.vehicle.make);
        this.models =  selectedMake ? selectedMake.models : [];
    }
}