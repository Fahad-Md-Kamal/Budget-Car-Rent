using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetCarRental.Model.Model
{
    public class VehiclePhoto
    {
        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }

        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
