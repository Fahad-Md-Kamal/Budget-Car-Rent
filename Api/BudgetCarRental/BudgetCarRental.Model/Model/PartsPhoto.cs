using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetCarRental.Model.Model
{
    public class PartsPhoto
    {
        public int PartsId { get; set; }
        public Parts Parts { get; set; }

        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
