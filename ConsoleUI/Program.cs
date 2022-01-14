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

            CarTest();


            //CarManager carManager = new CarManager(new EfCarDal());//EfCarDal class'ını gönderdik CarManager parametresi ICarDal interface'i implemente eden bir class istiyor. EfCarDal ICarDal implemente ettiği için ICarDal tipinde parametre olarak gönderebiliyoruz.
            //foreach (var car in carManager.GetByUnitPrice(40, 1000))
            //{
            //    Console.WriteLine(car.Id + " - " + car.CarName + " - " + car.DailyPrice + " - " + car.Description);
            //}

            //Car car1 = new Car();
            //car1.BrandId = 1;
            //car1.ColorId = 1;
            //car1.CategoryId = 1;
            //car1.CarName = "Bmw 520i"; //Araba ismi minimum 2 karakter olmalıdır
            //car1.ModelYear = 2019;
            //car1.DailyPrice = 850; //Araba günlük fiyatı 0'dan büyük olmalıdır.
            //car1.Description = "Lüks Sedan";

            //carManager.Add(car1);



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
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());//EfProdcutDal yazdıktan sonra buraya yazdık. Bu PnP oldu yani tak çalıştır. Diğer hiçbir katmana dokunmadık EfProdcutDal oluşturduk ve buraya yazdık.Sitem bir anda EntityFramework altyapısına dönmüş oldu.
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " - " + car.BrandName+" - "+car.CategoryName+" - "+car.ColorName+" - "+car.DailyPrice+" - "+car.ModelYear);
            } 
        }

    }
}
