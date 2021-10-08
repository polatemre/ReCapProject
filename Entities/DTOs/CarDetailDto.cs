using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string CategoryName { get; set; }
        public string FuelType { get; set; }
        public double DailyPrice { get; set; }
        public string ModelName { get; set; }
        public string ModelYear { get; set; }
        public string Description { get; set; }
        public string Seat { get; set; }
        public string Bag { get; set; }
        public string Gear { get; set; }

        public DateTime CarImageDate { get; set; }
        public string ImagePath { get; set; }

    }
}
