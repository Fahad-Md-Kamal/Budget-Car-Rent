namespace BudgetCarRental.Model.Model
{
    public class CustomerContact
    {
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
    }
}