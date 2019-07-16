using System.Collections.Generic;

namespace BudgetCarRental.Model.Model
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string ModelName { get; set; }
        public string RegNo { get; set; }
        public virtual EnumVehicleType Type { get; set; }
        public bool IsAvailable { get; set; }

        public virtual ICollection<VehicleFleet> VehicleFleets { get; set; }
        public virtual ICollection<VehicleDescription> Descriptions { get; set; }
        public virtual ICollection<RentalArrangement> RentalArrangements { get; set; }
        public virtual ICollection<VehiclePhoto> VehiclePhotos { get; set; }
    }
}