namespace BudgetCarRental.Model.Model
{
    public class DriverPayment
    {
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}