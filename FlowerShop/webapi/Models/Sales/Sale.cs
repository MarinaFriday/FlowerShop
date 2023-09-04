﻿using webapi.Models.Expanses;
using webapi.Models.Flowers;

namespace webapi.Models.Sales
{
    public class Sale
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public int CategoryId { get; set; }
        public CategorySale CategorySale { get; set; }
        public int FlowerId { get; set; }
        public Flower Flower { get; set; }
    }
}
