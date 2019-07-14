using System;
using System.Collections.Generic;

namespace BudgetCarRental.Model.Model
{
    public class RepairSession
    {
        public int RepairSessionId { get; set; }
        public virtual RentalArrangement RentalArrangement { get; set; }
        public DateTime? RepairDate { get; set; }

        public virtual ICollection<RepairingEmployee> RepairingEmployees { get; set; }
        public virtual ICollection<PartsForRepair> PartsForRepairs { get; set; }
    }
}