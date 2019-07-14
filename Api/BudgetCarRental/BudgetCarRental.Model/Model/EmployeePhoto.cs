using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetCarRental.Model.Model
{
    public class EmployeePhoto
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public int PhotoId { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
