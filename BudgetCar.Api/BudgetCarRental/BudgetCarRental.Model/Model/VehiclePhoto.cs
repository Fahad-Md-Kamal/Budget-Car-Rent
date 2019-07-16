using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetCarRental.Model.Model
{
    public class VehiclePhoto
    {
        public int VehicleID { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        public int PhotoId { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
