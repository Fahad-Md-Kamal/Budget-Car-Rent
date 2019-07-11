using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetCarRental.Model.Model
{
    public class CustomerPhoto
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
