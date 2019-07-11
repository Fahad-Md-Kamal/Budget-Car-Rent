using System;
using System.Collections.Generic;

namespace BudgetCarRental.Model.Model
{
    public class Fleet
    {
        public int FleetId { get; set; }
        public Customer Customer { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<FleetPayment> FleetPayments { get; set; }
        public ICollection<VehicleFleet> VehicleFleets { get; set; }
    }
}