namespace BudgetCarRental.Model.Model
{
    public class VehicleDescription
    {
        public int VehicleDescriptionId { get; set; }
        public string Description { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}