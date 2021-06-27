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
            CarTest();
            //CarTest2();
        }

        private static void CarTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            CarManager carManager = new CarManager(new EfCarDal());


            Console.WriteLine("Car Table:");
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Id:{0} BrandId:{1} ColorId:{2} Description:{3} DailyPrice:{4}", car.Id, car.BrandId, car.ColorId, car.Description, car.DailyPrice);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            Console.WriteLine("BrandId:1");
            var result2 = carManager.GetCarsByBrandId(1);
            if (result2.Success)
            {
                foreach (var car in result2.Data)
                {
                    Console.WriteLine("Id:{0} BrandId:{1} ColorId:{2} Description:{3} DailyPrice:{4}", car.Id, car.BrandId, car.ColorId, car.Description, car.DailyPrice);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(result2.Message);
            }


            Console.WriteLine("ColorId:1");
            var result3 = carManager.GetCarsByColorId(1);
            if (true)
            {
                foreach (var car in result3.Data)
                {
                    Console.WriteLine("Id:{0} BrandId:{1} ColorId:{2} Description:{3} DailyPrice:{4}", car.Id, car.BrandId, car.ColorId, car.Description, car.DailyPrice);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(result3.Message);
            }
        }
    }
}
