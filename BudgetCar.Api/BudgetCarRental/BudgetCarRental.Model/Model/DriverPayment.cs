namespace BudgetCarRental.Model.Model
{
    public class DriverPayment
    {
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; }

        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
    }
}