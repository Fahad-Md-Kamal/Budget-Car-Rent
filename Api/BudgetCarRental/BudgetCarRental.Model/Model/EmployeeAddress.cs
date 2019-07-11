namespace BudgetCarRental.Model.Model
{
    public class EmployeeAddress
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}