using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetCarRental.Model.Model
{
    public class DriverPhoto
    {
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
