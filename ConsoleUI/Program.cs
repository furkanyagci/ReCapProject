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
            Rental rental = new Rental();
            rental.CarId = 1;
            rental.CustomerId = 1;
            string date = DateTime.Now.ToString("MM.dd.yyyy hh:mm:ss");
            rental.RentDate = Convert.ToDateTime(date);
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine(rentalManager.Add(rental).Message);




            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //Customer customer = new Customer();
            //customer.UserId = 7;
            //customer.CompanyName = "KK AŞ";
            //customerManager.Add(customer);

            //UserManager userManager = new UserManager(new EfUserDal());
            //User user = new User();
            //user.FirstName = "Kazım";
            //user.LastName = "Karabekir";
            //user.Email = "Kazimkarabekir@gmail.com";
            //user.Password = "987654321";

            //Console.WriteLine(userManager.Add(user).Message);
            //user.Id = 6;
            //userManager.Delete(user);





            //CarManager carManager = new CarManager(new EfCarDal());
            //Car car = new Car();
            //car.BrandId = 1002;
            //car.ColorId = 1002;
            //car.CategoryId = 3;
            //car.CarName = "Bmw"; //Araba ismi minimum 2 karakter olmalıdır
            //car.ModelYear = 2022;
            //car.DailyPrice = 1050; //Araba günlük fiyatı 0'dan büyük olmalıdır.
            //car.Description = "Son Model Lüks Sedan";

            //Console.WriteLine(CarAdd(carManager, car).Message);
            //CarTest();
            //car.Id = 1003;//Id silinecek carid olmalı
            //CarDelete(carManager, car);//metot içinde id gönder

            //BrandGetAll();
            //BrandAdd(new Brand { Name = "Yeni Model" });

            ////ColorGetAll();
            //ColorAdd(new Color { Name = "Yeni Renk" });

            ////CategoryGetAll();
            //CategoryAdd(new Category { CategoryName = "Yeni Kategori" });
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
