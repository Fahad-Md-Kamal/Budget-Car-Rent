namespace BudgetCarRental.Model.Model
{
    public class VehicleFleet
    {
        public int FleetId { get; set; }
        public Fleet Fleet { get; set; }
        
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}