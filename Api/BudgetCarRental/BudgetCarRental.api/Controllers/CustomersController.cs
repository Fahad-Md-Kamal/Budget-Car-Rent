using BudgetCarRental.api.Data;
using BudgetCarRental.Model.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetCarRental.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ICollection<Customer> GetAllCustomer()
        {
            return _context.Customers.OrderBy(x => x.CustomerId).ToList();
        }
    }
}
