using System.Collections.Generic;

namespace BudgetCarRental.Model.Model
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Detail { get; set; }
        public bool IsDeleted { get; set; }
        
        public ICollection<CustomerContact> CustomerContacts { get; set; }
        public ICollection<DriverContact> DriverContacts { get; set; }
    }
}