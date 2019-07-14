using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BudgetCarRental.Model.Model
{
    public class Driver 
    {
        public int DriverId { get; set; }
        public string UniqeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string InsuranceNumber { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime JoinDate { get; set; }

        public AppUser AppUser { get; set; }

        public ICollection<DriverAddress> DriverAddresses { get; set; }
        public ICollection<DriverContact> DriverContacts { get; set; }
        public ICollection<DriverPayment> DriverPayments { get; set; }
        public ICollection<DriverPhoto> DriverPhotos { get; set; }
        public ICollection<RentalArrangement> RentalArrangements { get; set; }
    }
}