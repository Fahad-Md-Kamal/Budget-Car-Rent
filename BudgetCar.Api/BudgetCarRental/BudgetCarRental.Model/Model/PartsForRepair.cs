namespace BudgetCarRental.Model.Model
{
    public class PartsForRepair
    {
        public int PartsId { get; set; }
        public virtual Parts Parts { get; set; }

        public int Qty { get; set; }

        public int RepairId { get; set; }
        public virtual RepairSession RepairSession { get; set; }
    }
}