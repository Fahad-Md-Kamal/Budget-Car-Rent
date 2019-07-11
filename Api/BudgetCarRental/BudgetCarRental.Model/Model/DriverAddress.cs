namespace BudgetCarRental.Model.Model
{
    public class DriverAddress
    {
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}