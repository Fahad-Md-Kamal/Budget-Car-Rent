using System.Collections.Generic;

namespace BudgetCarRental.Model.Model
{
    public class VehicleFleet
    {
        public int FleetId { get; set; }
        public virtual Fleet Fleet { get; set; }

        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}