export interface Vehicle {
    VehicleId: number ;
    ModelName: string ;
    RegNo: string;
    Type: number;
    IsAvailable: boolean;
}


export interface VehiclesState {
    vehicles: Vehicle[];
}
