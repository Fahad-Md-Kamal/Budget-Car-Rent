namespace BudgetCarRental.Model.Model
{
    public class FleetPayment
    {
        public int FleetId { get; set; }
        public virtual Fleet Fleet { get; set; }

        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
    }
}