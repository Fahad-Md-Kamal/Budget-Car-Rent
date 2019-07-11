namespace BudgetCarRental.Model.Model
{
    public class FleetPayment
    {
        public int FleetId { get; set; }
        public Fleet Fleet { get; set; }

        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}