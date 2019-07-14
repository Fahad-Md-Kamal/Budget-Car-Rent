using System;
using System.Collections.Generic;

namespace BudgetCarRental.Model.Model
{
    public class RentalArrangement
    {
        public int RentalArrangementId { get; set; }
        public virtual EnumArrangementType ArrangementType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Vehicle Vehicle { get; set; }
        public virtual Driver Driver { get; set; }

        public virtual ICollection<RepairSession> RepairSessions { get; set; }
    }
}