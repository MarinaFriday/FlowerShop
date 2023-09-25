using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.Eventing.Reader;
using webapi.Data;
using webapi.Models.Flowers;
using System.Threading.Tasks;

namespace webapi.Services
{
    public class FlowerService
    {
        private DataContext _context;
        public FlowerService(DataContext context) {
            _context=context;
        }

        /*public Flower AddFlower(Flower flower) {

            return flower;
        }*/
        public Flower AddFlower(Flower flower) 
        { 
            flower.Title = flower.Title.Trim();
            _context.Flowers.Add(flower);   
            _context.SaveChanges();
            return flower;
        }
        //
        public async Task<ActionResult<IEnumerable<Flower>>> ListFlowers() 
        { 

        return await _context.Flowers.ToListAsync();

        }

        
    }
}
