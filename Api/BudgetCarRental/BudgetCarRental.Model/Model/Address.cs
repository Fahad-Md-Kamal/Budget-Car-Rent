using System.Collections.Generic;

namespace BudgetCarRental.Model.Model
{
    public class Address
    {
        public int AddressId { get; set; }
        public string House { get; set; }
        public string Road { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<DriverAddress> DriverAddresses { get; set; }
    }
}