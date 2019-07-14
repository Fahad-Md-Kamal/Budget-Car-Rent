namespace BudgetCarRental.Model.Model
{
    public class DriverAddress
    {
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}