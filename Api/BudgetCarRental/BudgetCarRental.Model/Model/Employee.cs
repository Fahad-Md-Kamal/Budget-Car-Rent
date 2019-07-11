using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BudgetCarRental.Model.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeId{ get; set; }
        public string UsinqId { get; set; }
        public string DepartmentName { get; set; }
        public bool IsAvailable { get; set; }
        
        public AppUser AppUser { get; set; }

        public ICollection<EmployeeContact> EmployeeContacts { get; set; }
        public ICollection<EmployeeAddress> EmployeeAddresses { get; set; }
        public ICollection<EmployeePhoto> EmployeePhotos { get; set; }
        public ICollection<RepairingEmployee> RepairingEmployees { get; set; }
    }
}