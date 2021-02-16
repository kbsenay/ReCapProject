using Business.Concrete;
using Business.Constants;
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
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            RentalsListMethod(rentalManager);
            //RentalDeleteMethod(rentalManager);
            //RentalAddMethod(rentalManager);
            //CustomerAddMethod(customerManager);
            //AddUser(userManager);
            //Test(carManager);
            //TestGetDetail(carManager);
            //TestDeleteMethodForBrandAndColor(brandManager, colorManager);
            //TestAddMethodForBrandAndColor(brandManager, colorManager);
            //TestCarDelete(carManager);
            //TestGetMethodForBrandAndColor(brandManager, colorManager);
            //TestGetMethods(carManager);
            //TestAddMethods(carManager);



        }

        private static void RentalsListMethod(RentalManager rentalManager)
        {
            var result = rentalManager.GetAll();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarId + " " + "|" + " " + car.CarId + " " + "|" + " "
                    + car.RentDate + " " + "|" + " " + car.ReturnDate);
            }
            Console.WriteLine(Messages.RentalListed);
        }

        private static void RentalDeleteMethod(RentalManager rentalManager)
        {
            rentalManager.Delete(new Rental { Id = 3 });
            Console.WriteLine(Messages.RentalDeleted);
        }

        private static void RentalAddMethod(RentalManager rentalManager)
        {
            var Result = rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 4,
                RentDate = new DateTime(2021, 2, 16),
                ReturnDate = new DateTime(2021, 2, 19),
            });
            Console.WriteLine(Result.Message);
        }

        private static void CustomerAddMethod(CustomerManager customerManager)
        {
            customerManager.Add(new Customer { UserId = 1002, CompanyName = "Vet. Ltd." });
            Console.WriteLine(Messages.CustomerAdded);
        }

        private static void AddUser(UserManager userManager)
        {
            userManager.Add(new User
            {
                FirstName = "Ahmet",
                LastName = "ÇAKMAK",
                Email = "ahmet55@hotmail.com",
                Password = "12344321"
            });
        }

        //        private static void Test(CarManager carManager)
        //        {
        //            var result = carManager.GetCarDetails();
        //            if (result.Success == true)
        //            {
        //                foreach (var car in result.Data)
        //                {
        //                    Console.WriteLine(car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
        //                }
        //            }
        //        }

        //        private static void TestGetDetail(CarManager carManager)
        //        {
        //            foreach (var car in carManager.GetCarDetails().Data)
        //            {
        //                Console.WriteLine(car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
        //            }
        //        }


        //        private static void TestDeleteMethodForBrandAndColor(BrandManager brandManager, ColorManager colorManager)
        //        {
        //            brandManager.Delete(new Brand { BrandId = 6 });
        //            colorManager.Delete(new Color { ColorId = 5 });
        //        }

        //        private static void TestAddMethodForBrandAndColor(BrandManager brandManager, ColorManager colorManager)
        //        {
        //            colorManager.Add(new Color { ColorName = "Yeşil" });
        //            brandManager.Add(new Brand { BrandName = "Peugeout" });
        //        }

        //        private static void TestCarDelete(CarManager carManager)
        //        {
        //            carManager.Delete(new Car { CarId = 2004 });
        //        }

        //        private static void TestGetMethodForBrandAndColor(BrandManager brandManager, ColorManager colorManager)
        //        {
        //            Console.WriteLine("------ID'ye Göre Marka Adları---------");
        //            var result = brandManager.GetByBrandId(1);
        //            if (result.Success==true)
        //            {
        //                foreach (var brand in result.Data)
        //                {
        //                    Console.WriteLine(brand);
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine(result.Message);
        //            }

        //            Console.WriteLine("------ID'ye Göre Renk Seçenekleri---------");
        //            foreach (var color in colorManager.GetByColorId(1).Data)
        //            {
        //                Console.WriteLine(color);
        //            }
        //        }

        //        private static void TestAddMethods(CarManager carManager)
        //        {

        //            carManager.Add(new Car
        //            {
        //                BrandId = 2,
        //                ColorId = 1,
        //                ModelYear = 2011,
        //                DailyPrice = 200,
        //                Description = "Fluence"
        //            });
        //            carManager.Add(new Car
        //            {
        //                BrandId = 3,
        //                ColorId = 2,
        //                ModelYear = 2018,
        //                DailyPrice = 200,
        //                Description = "Vectra"
        //            });
        //            carManager.Add(new Car
        //            {
        //                BrandId = 3,
        //                ColorId = 1,
        //                ModelYear = 2004,
        //                DailyPrice = 150,
        //                Description = "Astra"
        //            });
        //            carManager.Add(new Car
        //            {
        //                BrandId = 1,
        //                ColorId = 2,
        //                ModelYear = 2010,
        //                DailyPrice = 150,
        //                Description = "Focus"
        //            });
        //            carManager.Add(new Car
        //            {
        //                BrandId = 4,
        //                ColorId = 3,
        //                ModelYear = 2008,
        //                DailyPrice = 400,
        //                Description = "CLK 200 Kompressor"
        //            });
        //            carManager.Add(new Car
        //            {
        //                BrandId = 5,
        //                ColorId = 4,
        //                ModelYear = 2008,
        //                DailyPrice = 300,
        //                Description = "520 d Standart"
        //            });
        //        }

        //        private static void TestGetMethods(CarManager carManager)
        //        {
        //            foreach (var car in carManager.GetByDailyPrice(100, 200).Data)
        //            {
        //                Console.WriteLine(car.Description);
        //            }
        //            Console.WriteLine("----------Fiyata Göre Getir-----------");

        //            foreach (var car in carManager.GetById(3).Data.Brandname)
        //            {
        //                Console.WriteLine(car);
        //            }
        //            Console.WriteLine("----------ID'ye Göre Getir-----------");
        //        }
    }
}
