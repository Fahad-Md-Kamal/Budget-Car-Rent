using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetCarRental.Model.Model
{
    public class EmployeePhoto
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
