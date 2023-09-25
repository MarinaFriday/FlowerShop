using Microsoft.AspNetCore.Mvc;
using webapi.Data;
using webapi.Models.Flowers;
using webapi.Services;
using System.Threading.Tasks;


namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlowerController : ControllerBase
    {
        private readonly DataContext _context;
        public FlowerController(DataContext context) {
            _context=context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flower>>> GetFlower() {
            FlowerService fs = new FlowerService(_context);
            return await fs.ListFlowers();
        }

        [HttpPost]
        public async Task<ActionResult<Flower>> PostFlower(Flower flower) {
            FlowerService fs = new FlowerService(_context);
            var result = fs.AddFlower(flower);
            return result == null ? BadRequest("Ошибка в цветке") : result;
        }

    }
}
