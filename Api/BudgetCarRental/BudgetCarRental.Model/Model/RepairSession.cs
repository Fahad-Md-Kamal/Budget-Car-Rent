using System;
using System.Collections.Generic;

namespace BudgetCarRental.Model.Model
{
    public class RepairSession
    {
        public int RepairSessionId { get; set; }
        public RentalArrangement RentalArrangement { get; set; }
        public DateTime? RepairDate { get; set; }

        public ICollection<RepairingEmployee> RepairingEmployees { get; set; }
        public ICollection<PartsForRepair> PartsForRepairs { get; set; }
    }
}