namespace BudgetCarRental.Model.Model
{
    public class PartsForRepair
    {
        public int PartsId { get; set; }
        public Parts Parts { get; set; }

        public int Qty { get; set; }

        public int RepairId { get; set; }
        public RepairSession RepairSession { get; set; }
    }
}