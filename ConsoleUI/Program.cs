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

            CarManager carManager = new CarManager(new EfCarDal());//EfProdcutDal yazdıktan sonra buraya yazdık. Bu PnP oldu yani tak çalıştır. Diğer hiçbir katmana dokunmadık EfProdcutDal oluşturduk ve buraya yazdık.Sitem bir anda EntityFramework altyapısına dönmüş oldu.
            foreach (var car in carManager.GetByUnitPrice(40, 1000))
            {
                Console.WriteLine(car.Id+" - "+car.DailyPrice+" - "+car.Description);
            }


            //CarManager carManager = new CarManager(new InMemoryCarDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id+" - "+car.BrandId +" - " + car.CategoryId +" - " +car.ColorId +" - " + car.ModelYear + " - " +car.Description+" - "+ car.DailyPrice);
            //}

            //Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            //Car car1 = new Car { Id = 5, BrandId = 98, CategoryId = 1, ColorId = 30, DailyPrice = 1250, Description = "Station Wagon otomobil", ModelYear = 2022 };
            //carManager.Add(car1);

            //Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            //carManager.Delete(car1);

            //Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            //foreach (var car in carManager.GetAllByCategory(2))
            //{
            //    Console.WriteLine("GetAllByCategory ile çağırılan : " + car.Id + " - " + car.BrandId + " - " + car.CategoryId + " - " + car.ColorId + " - " + car.ModelYear + " - " + car.Description + " - " + car.DailyPrice);
            //}

            //Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            //foreach (var car in carManager.GetById(2))
            //{
            //    Console.WriteLine("GetById ile çağırılan : " + car.Id + " - " + car.BrandId + " - " + car.CategoryId + " - " + car.ColorId + " - " + car.ModelYear + " - " + car.Description + " - " + car.DailyPrice);
            //}

            //Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            //Car car2 = new Car { Id = 1, BrandId = 98, CategoryId = 7, ColorId = 30, DailyPrice = 999, Description = "Sport sedan otomobil", ModelYear = 2023 };

            //carManager.Update(car2);

            //Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id + " - " + car.BrandId + " - " + car.CategoryId + " - " + car.ColorId + " - " + car.ModelYear + " - " + car.Description + " - " + car.DailyPrice);
            //}

        }
    }
}
