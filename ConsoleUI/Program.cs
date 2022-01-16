using Business.Concrete;
using Core.Utilities.Results;
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
            Car car = new Car();
            car.BrandId = 1002;
            car.ColorId = 1002;
            car.CategoryId = 3;
            car.CarName = "Bmw"; //Araba ismi minimum 2 karakter olmalıdır
            car.ModelYear = 2022;
            car.DailyPrice = 1050; //Araba günlük fiyatı 0'dan büyük olmalıdır.
            car.Description = "Son Model Lüks Sedan";

            Console.WriteLine(CarAdd(carManager, car).Message);
            CarTest();
            //car.Id = 1003;//Id silinecek carid olmalı
            //CarDelete(carManager, car);//metot içinde id gönder

            //BrandGetAll();
            //BrandAdd(new Brand { Name = "Yeni Model" });

            ////ColorGetAll();
            //ColorAdd(new Color { Name = "Yeni Renk" });

            ////CategoryGetAll();
            //CategoryAdd(new Category { CategoryName = "Yeni Kategori" });




            //CarManager carManager = new CarManager(new EfCarDal());//EfCarDal class'ını gönderdik CarManager parametresi ICarDal interface'i implemente eden bir class istiyor. EfCarDal ICarDal implemente ettiği için ICarDal tipinde parametre olarak gönderebiliyoruz.
            //foreach (var car in carManager.GetByUnitPrice(40, 1000))
            //{
            //    Console.WriteLine(car.Id + " - " + car.CarName + " - " + car.DailyPrice + " - " + car.Description);
            //}

            //CarManager carManager = new CarManager(new InMemoryCarDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id+" - "+car.BrandId +" - " + car.CategoryId +" - " +car.ColorId +" - " + car.ModelYear + " - " +car.Description+" - "+ car.DailyPrice);
            //}

            //Car car1 = new Car { Id = 5, BrandId = 98, CategoryId = 1, ColorId = 30, DailyPrice = 1250, Description = "Station Wagon otomobil", ModelYear = 2022 };
            //carManager.Add(car1);

            //carManager.Delete(car1);

            //foreach (var car in carManager.GetAllByCategory(2))
            //{
            //    Console.WriteLine("GetAllByCategory ile çağırılan : " + car.Id + " - " + car.BrandId + " - " + car.CategoryId + " - " + car.ColorId + " - " + car.ModelYear + " - " + car.Description + " - " + car.DailyPrice);
            //}

            //foreach (var car in carManager.GetById(2))
            //{
            //    Console.WriteLine("GetById ile çağırılan : " + car.Id + " - " + car.BrandId + " - " + car.CategoryId + " - " + car.ColorId + " - " + car.ModelYear + " - " + car.Description + " - " + car.DailyPrice);
            //}

            //Car car2 = new Car { Id = 1, BrandId = 98, CategoryId = 7, ColorId = 30, DailyPrice = 999, Description = "Sport sedan otomobil", ModelYear = 2023 };
            //carManager.Update(car2);

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id + " - " + car.BrandId + " - " + car.CategoryId + " - " + car.ColorId + " - " + car.ModelYear + " - " + car.Description + " - " + car.DailyPrice);
            //}

        }

        private static void ColorAdd(Color color)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(color);
        }

        private static void BrandAdd(Brand brand)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(brand);
        }

        private static void CategoryAdd(Category category)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            categoryManager.Add(category);
        }

        private static void CarDelete(CarManager carManager, Car car)
        {
            carManager.Delete(car);
        }

        private static IResult CarAdd(CarManager carManager, Car car)
        {
            return carManager.Add(car);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());//EfProdcutDal yazdıktan sonra buraya yazdık. Bu PnP oldu yani tak çalıştır. Diğer hiçbir katmana dokunmadık EfProdcutDal oluşturduk ve buraya yazdık.Sitem bir anda EntityFramework altyapısına dönmüş oldu.
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " - " + car.BrandName + " - " + car.CategoryName + " - " + car.ColorName + " - " + car.DailyPrice + " - " + car.ModelYear);
            }
        }

        private static void CategoryGetAll()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.Id + " - " + category.CategoryName);
            }
        }

        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Id + " - " + color.Name);
            }
        }

        private static void BrandGetAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Id + " - " + brand.Name);
            }
        }
    }
}
