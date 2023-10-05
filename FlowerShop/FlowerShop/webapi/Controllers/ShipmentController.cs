using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using webapi.Data;
using webapi.Models.Flowers;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        private readonly DataContext _context;
        public ShipmentController(DataContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shipment>>> GetShipments() {
            return await _context.Shipments.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Shipment>> GetShipment(int id) { 
            
        }
    }
}
