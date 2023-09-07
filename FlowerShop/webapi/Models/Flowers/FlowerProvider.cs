namespace webapi.Models.Flowers
{
    public class FlowerProvider
    {
        public int FlowerId { get; set; }
        public int ProviderId { get; set; }
        public Flower Flower { get; set; }
        public Provider Provider { get; set; }
    }
}
