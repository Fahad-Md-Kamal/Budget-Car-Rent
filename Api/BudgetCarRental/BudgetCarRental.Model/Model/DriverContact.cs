namespace BudgetCarRental.Model.Model
{
    public class DriverContact
    {
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; }

        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
    }
}