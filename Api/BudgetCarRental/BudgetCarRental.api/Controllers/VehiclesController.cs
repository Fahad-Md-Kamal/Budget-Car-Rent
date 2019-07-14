using BudgetCarRental.api.Data;
using BudgetCarRental.Model.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetCarRental.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController: ControllerBase
    {
        private readonly AppDbContext _context;

        public VehiclesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVehicles()
        {
            var v = await _context.Vehicles
                .Include(x=> x.VehiclePhotos)
                    .ThenInclude(P => P.Photo)
                .Include(x => x.Descriptions)
                .Include(f => f.VehicleFleets)
                    .ThenInclude(f => f.Fleet)
                        .ThenInclude( f => f.Customer)
                .OrderBy(x => x.Model).ToListAsync();
            return Ok(v);
        }

    }
}
