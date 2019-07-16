using System;
using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using Microsoft.AspNetCore.Identity;

namespace BudgetCarRental.Model.Model
{
    public class Customer 
    {
        public int CustomerId { get; set; }
        public string OrganizationName { get; set; }
        public virtual EnumCustomerType CustomerType { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual ICollection<CustomerContact> CustomerContacts { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<Fleet> Fleets { get; set; }
        public virtual ICollection<CustomerPhoto> CustomerPhotos { get; set; }
    }
}