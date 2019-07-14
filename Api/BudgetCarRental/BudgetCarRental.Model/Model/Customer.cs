using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BudgetCarRental.Model.Model
{
    public class Customer 
    {
        public int CustomerId { get; set; }
        public string OrganizationName { get; set; }
        public EnumCustomerType CustomerType { get; set; }

        public AppUser AppUser { get; set; }

        public ICollection<CustomerContact> CustomerContacts { get; set; }
        public ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public ICollection<Fleet> Fleets { get; set; }
        public ICollection<CustomerPhoto> CustomerPhotos { get; set; }
    }
}