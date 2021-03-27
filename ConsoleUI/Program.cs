using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorTest();


          


        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                BrandId = 2,
                ColorId = 3,
                DailyPrice = 300,
                Description = "Güzel",
                ModelYear = 2011
            });
            Console.WriteLine("Car Added.");
            carManager.Update(new Car
            {
                Id = 4,
                BrandId = 3,
                ColorId = 4,
                DailyPrice = 300,
                Description = "Normal",
                ModelYear = 2021,


            });
            Console.WriteLine("Updated");

            carManager.Delete(new Car { Id = 4 });
            Console.WriteLine("Car Deleted");

            Console.WriteLine("***Car List***");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " \n" + car.DailyPrice + " \n" + car.ModelYear);
            }
        }
        private static void BrandTest()
        {

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 12, BrandName="Tesla" });
            brandManager.Add(new Brand { BrandId = 5, BrandName = "Range Rover" });
            brandManager.Add(new Brand { BrandId = 6, BrandName = "Range" });
            Console.WriteLine("Brand added.");
            brandManager.Update(new Brand { BrandId = 12, BrandName = "Volvo" });
            Console.WriteLine("Brand updated.");
            brandManager.Delete(new Brand { BrandId = 6 });
            Console.WriteLine("Brand deleted.");

            Console.WriteLine("***List of Brand***");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorId = 1, ColorName = "Sarı" });
            colorManager.Add(new Color { ColorId = 2, ColorName = "Kırmızı" });
            colorManager.Add(new Color { ColorId = 3, ColorName = "Mavi" });
            colorManager.Add(new Color { ColorId = 4, ColorName = "Siyah" });
            Console.WriteLine("Added");
            colorManager.Update(new Color { ColorId = 3, ColorName = "Turuncu" });
            Console.WriteLine("Updated");
            colorManager.Delete(new Color { ColorId = 4 });
            Console.WriteLine("***List of Color***");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }
    }

  
}

