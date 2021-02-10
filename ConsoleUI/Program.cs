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

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + "/"+ car.ColorName);
            }
            
            
            //TestDeleteMethodForBrandAndColor(brandManager, colorManager);
            //TestAddMethodForBrandAndColor(brandManager, colorManager);
            //TestCarDelete(carManager);
            //TestGetMethodForBrandAndColor(brandManager, colorManager);
            //TestGetMethods(carManager);
            //TestAddMethods(carManager);



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
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("------ID'ye Göre Renk Seçenekleri---------");
            foreach (var color in colorManager.GetByColorId(1))
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void TestAddMethods(CarManager carManager)
        {
            carManager.Add(new Car
            {
                BrandId = 3,
                ColorId = 1,
                ModelYear = 2004,
                DailyPrice = 70000,
                Description = "Opel Astra"
            });
            carManager.Add(new Car
            {
                BrandId = 1,
                ColorId = 2,
                ModelYear = 2010,
                DailyPrice = 105000,
                Description = "Ford Focus"
            });
        }

        private static void TestGetMethods(CarManager carManager)
        {
            foreach (var car in carManager.GetByDailyPrice(50000, 140000))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("----------Fiyata Göre Getir-----------");

            foreach (var car in carManager.GetById(3))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("----------ID'ye Göre Getir-----------");
        }
    }
}
