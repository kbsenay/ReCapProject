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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName +"/"+car.ColorName+"/"+car.DailyPrice);
                }
            }
            
            
            
            
            //TestGetDetail(carManager);
            //TestDeleteMethodForBrandAndColor(brandManager, colorManager);
            //TestAddMethodForBrandAndColor(brandManager, colorManager);
            //TestCarDelete(carManager);
            //TestGetMethodForBrandAndColor(brandManager, colorManager);
            //TestGetMethods(carManager);
            //TestAddMethods(carManager);



        }

        private static void TestGetDetail(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }


        private static void TestDeleteMethodForBrandAndColor(BrandManager brandManager, ColorManager colorManager)
        {
            brandManager.Delete(new Brand { BrandId = 6 });
            colorManager.Delete(new Color { ColorId = 5 });
        }

        private static void TestAddMethodForBrandAndColor(BrandManager brandManager, ColorManager colorManager)
        {
            colorManager.Add(new Color { ColorName = "Yeşil" });
            brandManager.Add(new Brand { BrandName = "Peugeout" });
        }

        private static void TestCarDelete(CarManager carManager)
        {
            carManager.Delete(new Car { CarId = 2004 });
        }

        private static void TestGetMethodForBrandAndColor(BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine("------ID'ye Göre Marka Adları---------");
            foreach (var brand in brandManager.GetByBrandId(2))
            {
                Console.WriteLine(brand);
            }
            Console.WriteLine("------ID'ye Göre Renk Seçenekleri---------");
            foreach (var color in colorManager.GetByColorId(1).ColorName)
            {
                Console.WriteLine(color);
            }
        }

        private static void TestAddMethods(CarManager carManager)
        {
            carManager.Add(new Car
            {
                BrandId = 3,
                ColorId = 1,
                ModelYear = 2004,
                DailyPrice = 150,
                Description = "Opel Astra"
            });
            carManager.Add(new Car
            {
                BrandId = 1,
                ColorId = 2,
                ModelYear = 2010,
                DailyPrice = 150,
                Description = "Ford Focus"
            });
        }

        private static void TestGetMethods(CarManager carManager)
        {
            foreach (var car in carManager.GetByDailyPrice(100, 200).Data)
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("----------Fiyata Göre Getir-----------");

            foreach (var car in carManager.GetById(3).Data.Brandname)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("----------ID'ye Göre Getir-----------");
        }
    }
}
