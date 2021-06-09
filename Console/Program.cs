using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Car Table:");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id:{0} BrandId:{1} ColorId:{2} Description:{3} DailyPrice:{4}", car.Id, car.BrandId, car.ColorId, car.Description, car.DailyPrice);
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("BrandId:1");
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("Id:{0} BrandId:{1} ColorId:{2} Description:{3} DailyPrice:{4}", car.Id, car.BrandId, car.ColorId, car.Description, car.DailyPrice);
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("ColorId:1");
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine("Id:{0} BrandId:{1} ColorId:{2} Description:{3} DailyPrice:{4}", car.Id, car.BrandId, car.ColorId, car.Description, car.DailyPrice);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
