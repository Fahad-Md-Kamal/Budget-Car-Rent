using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetCarRental.Model.Model
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal PaidAmount { get; set; }
        
        public ICollection<FleetPayment> FleetPayments { get; set; }
        public ICollection<DriverPayment> DriverPayments { get; set; }
    }
}