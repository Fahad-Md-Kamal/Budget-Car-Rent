namespace BudgetCarRental.Model.Model
{
    public class EmployeeContact
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }       
    }
}