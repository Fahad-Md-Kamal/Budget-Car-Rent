using System.Collections.Generic;

namespace BudgetCarRental.Model.Model
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Model { get; set; }
        public string RegNo { get; set; }
        public EnumVehicleType Type { get; set; }
        public bool IsAvailable { get; set; }

        public ICollection<VehicleFleet> VehicleFleets { get; set; }
        public ICollection<VehicleDescription> Descriptions { get; set; }
        public ICollection<RentalArrangement> RentalArrangements { get; set; }
        public ICollection<VehiclePhoto> VehiclePhotos { get; set; }
    }
}