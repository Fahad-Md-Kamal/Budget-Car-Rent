namespace BudgetCarRental.Model.Model
{
    public class EmployeeContact
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }       
    }
}