using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BudgetCarRental.Model.Model
{
    public class Employee 
    {
        [Key]
        public int EmployeeId { get; set; }
        public string UniqeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual EnumDepartment Department { get; set; }
        public bool IsAvailable { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual ICollection<EmployeeContact> EmployeeContacts { get; set; }
        public virtual ICollection<EmployeeAddress> EmployeeAddresses { get; set; }
        public virtual ICollection<EmployeePhoto> EmployeePhotos { get; set; }
        public virtual ICollection<RepairingEmployee> RepairingEmployees { get; set; }
    }
}