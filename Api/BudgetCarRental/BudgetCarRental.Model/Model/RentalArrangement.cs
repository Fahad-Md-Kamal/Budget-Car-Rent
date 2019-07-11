using System;

namespace BudgetCarRental.Model.Model
{
    public class RentalArrangement
    {
        public int RentalArrangementId { get; set; }
        public string ArrangementType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Vehicle Vehicle { get; set; }
        public Driver Driver { get; set; }
    }
}