namespace BudgetCarRental.Model.Model
{
    public class CustomerContact
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}