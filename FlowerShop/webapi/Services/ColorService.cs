using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using webapi.Data;
using webapi.Models.Flowers;

namespace webapi.Services
{
    public class ColorService
    {
        private DataContext _context;

        public ColorService(DataContext context)
        {
            _context=context;
        }
        //добавление цвета
        public Color AddColor(Color color)
        {
            color.ColorName = color.ColorName.Trim();
            _context.Colors.Add(color);
            _context.SaveChanges();
            return color;
        }
        //получение списка цветов
        public async Task<ActionResult<IEnumerable<Color>>> ListColors()
        {
            return await _context.Colors.ToListAsync();
        }
        //получение цвета по id

        //удаление цвета
        public Color DeleteColor(int id) {
            var color = _context.Colors.Find(id);
            if (color == null) return null;
            _context.Colors.Remove(color);
            _context.SaveChangesAsync();
            return color;        
        }
        //редактирование цвета 
        //
    }
}
