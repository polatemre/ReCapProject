using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int CategoryId { get; set; }
        public int FuelId { get; set; }
        public string ModelName { get; set; }
        public string ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Description { get; set; }
        public string Seat { get; set; }
        public string Bag { get; set; }
        public string Gear { get; set; }
    }
}
