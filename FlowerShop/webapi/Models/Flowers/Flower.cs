using System.Reflection;

namespace webapi.Models.Flowers
{
    public class Flower
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        //количество
        public uint Count { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }       
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Provider> Providers { get; set; }  

    }
}
