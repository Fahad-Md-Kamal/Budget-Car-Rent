using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetCarRental.Model.Model
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsMain { get; set; }
    }
}
