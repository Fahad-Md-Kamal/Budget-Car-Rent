using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetCarRental.Model.Model
{
    public class Parts
    {
        public int PartsId { get; set; }
        public string PartsCode { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public ICollection<PartsForRepair> PartsForRepairs { get; set; }
        public ICollection<PartsPhoto> PartsPhotos { get; set; }
    }
}