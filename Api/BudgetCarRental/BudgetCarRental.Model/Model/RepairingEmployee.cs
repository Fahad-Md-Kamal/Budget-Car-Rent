namespace BudgetCarRental.Model.Model
{
    public class RepairingEmployee
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
        public int RepairId { get; set; }
        public RepairSession RepairSession { get; set; }
    }
}