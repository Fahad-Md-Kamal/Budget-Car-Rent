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


        //public ICollection<CustomerPhoto> CustomerPhotos { get; set; }
        //public ICollection<EmployeePhoto> EmployeePhotos { get; set; }
        //public ICollection<DriverPhoto> DriverPhotos { get; set; }
        //public ICollection<VehiclePhoto> VehiclePhotos { get; set; }
        //public ICollection<PartsPhoto> PartsPhotos { get; set; }
    }
}
