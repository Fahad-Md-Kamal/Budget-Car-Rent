using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetCarRental.Model.Model
{
    public class CustomerPhoto
    {
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int PhotoId { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
