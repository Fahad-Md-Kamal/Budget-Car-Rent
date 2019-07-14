namespace BudgetCarRental.Model.Model
{
    public class RepairingEmployee
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        
        public int RepairId { get; set; }
        public virtual RepairSession RepairSession { get; set; }
    }
}