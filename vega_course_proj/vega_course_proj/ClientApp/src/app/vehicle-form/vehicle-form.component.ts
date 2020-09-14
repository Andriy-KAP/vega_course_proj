import { Component, OnInit } from "@angular/core";
import { FeatureService } from "./services/feature.service";
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

    constructor(private vehicleService: VehicleFormService, private featureService: FeatureService){

    }

    ngOnInit(): void {
        this.vehicleService.getMakes().subscribe((makes)=>{
            this.makes = makes;
        });
        this.featureService.getFeatures().subscribe((features)=>{
            this.features = features;
        });
        
    }

    public onMakeChange(): void{
        let selectedMake = this.makes.find(m=> m.Id == this.vehicle.make);
        this.models =  selectedMake ? selectedMake.models : [];
    }
}