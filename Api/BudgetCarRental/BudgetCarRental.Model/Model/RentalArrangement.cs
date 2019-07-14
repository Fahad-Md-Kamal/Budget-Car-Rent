using System;
using System.Collections.Generic;

namespace BudgetCarRental.Model.Model
{
    public class RentalArrangement
    {
        public int RentalArrangementId { get; set; }
        public EnumArrangementType ArrangementType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Vehicle Vehicle { get; set; }
        public Driver Driver { get; set; }

        public ICollection<RepairSession> RepairSessions { get; set; }
    }
}