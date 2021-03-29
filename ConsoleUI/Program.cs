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
            AddCustomer();
            AddRental();


          


        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car
            //{
            //    BrandId = 19,
            //    ColorId = 3,
            //    DailyPrice = 300,
            //    Description = "Güzel",
            //    ModelYear = 2011
            //});
            //Console.WriteLine("Car Added.");
            //carManager.Update(new Car
            //{
            //    Id = 2,
            //    BrandId = 3,
            //    ColorId = 4,
            //    DailyPrice = 300,
            //    Description = "Normal",
            //    ModelYear = 2021,


            //});
            //Console.WriteLine("Updated");

            //carManager.Delete(new Car { Id = 4 });
            //Console.WriteLine("Car Deleted");

            Console.WriteLine("***Car List***");
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }


        }
        private static void BrandTest()
        {

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandId = 12, BrandName="Tesla" });
            //brandManager.Add(new Brand { BrandId = 5, BrandName = "Range Rover" });
            //brandManager.Add(new Brand { BrandId = 6, BrandName = "Range" });
            //Console.WriteLine("Brand added.");
            //brandManager.Update(new Brand { BrandId = 12, BrandName = "Volvo" });
            //Console.WriteLine("Brand updated.");
            //brandManager.Delete(new Brand { BrandId = 6 });
            //Console.WriteLine("Brand deleted.");

            Console.WriteLine("***List of Brand***");
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }

        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorId = 1, ColorName = "Sarı" });
            //colorManager.Add(new Color { ColorId = 2, ColorName = "Kırmızı" });
            //colorManager.Add(new Color { ColorId = 3, ColorName = "Mavi" });
            //colorManager.Add(new Color { ColorId = 4, ColorName = "Siyah" });
            //Console.WriteLine("Added");
            //colorManager.Update(new Color { ColorId = 3, ColorName = "Turuncu" });
            //Console.WriteLine("Updated");
            //colorManager.Delete(new Color { ColorId = 4 });
            Console.WriteLine("***List of Color***");
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void AddRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental
            {
                RentDate=DateTime.Now,
                ReturnDate=DateTime.Now,
                CarId=1,
                CustomerId=1
            });

            if (result.Success==true)
            {
                Console.WriteLine(result.Message);

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void AddCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                CompanyName = "Mehmet",
                UserId = 1
                
                



            });
        }
    }
    

  
}

