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
            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetByDailyPrice(50000,140000))
            //{
            //    Console.WriteLine(car.Description);
            //}
            //carManager.Add(new Car {BrandId=3, ColorId=1, ModelYear=2004, DailyPrice=70000, Description="Opel Astra" });
            carManager.Add(new Car {BrandId = 1, ColorId = 2, ModelYear = 2010, DailyPrice = 105000, Description = "Ford Focus" });

        }
    }
}
