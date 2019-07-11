namespace BudgetCarRental.Model.Model
{
    public class DriverContact
    {
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}