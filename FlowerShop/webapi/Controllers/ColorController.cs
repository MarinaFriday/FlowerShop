using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;
using webapi.Data;
using webapi.Models.Flowers;
using webapi.Services;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private readonly DataContext _context;

        public ColorController(DataContext context) {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Color>> PostColor(Color color) {
            ColorService cs = new ColorService(_context);
            var result = cs.AddColor(color);
            return result == null ? BadRequest("Ошибка в добавлении цвета") : result;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Color>>> GetColor() {
            ColorService cs = new ColorService(_context);
            return await cs.ListColors();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColor(int id) {
            ColorService cs = new ColorService(_context);
            var color = cs.DeleteColor(id);
            if (color != null) return Ok();
            //??????
            return NoContent();
        }

    }
}
