namespace BudgetCarRental.Model.Model
{
    public class EmployeeAddress
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}