using System;
using Microsoft.AspNetCore.Identity;

namespace BudgetCarRental.Model.Model
{
    public class AppUser
    {
        public int AppUserId { get; set; }

        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public DateTime? JoinDate { get; set; }
    }
}