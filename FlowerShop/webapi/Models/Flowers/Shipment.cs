namespace webapi.Models.Flowers
{
    public class Shipment
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }
        public Provider Provider { get; set; }
        public ICollection<Flower> Flowers { get; set; }
    }
}
