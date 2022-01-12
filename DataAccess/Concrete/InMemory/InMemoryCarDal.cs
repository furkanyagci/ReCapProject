using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,CategoryId=1,BrandId=3,ColorId=90,DailyPrice=650,Description="Sedan Otomobil",ModelYear=2019},
                new Car{Id=2,CategoryId=2,BrandId=7,ColorId=13,DailyPrice=800,Description="Hatcback Otomobil",ModelYear=2020},
                new Car{Id=3,CategoryId=1,BrandId=6,ColorId=22,DailyPrice=750,Description="Coupe Otomobil",ModelYear=2022},
                new Car{Id=4,CategoryId=2,BrandId=9,ColorId=33,DailyPrice=450,Description="Sedan Otomobil",ModelYear=2018},
            };
        }


        public void Add(Car car)
        {
            _car.Add(car);
            Console.WriteLine(car.Id + " - " + car.Description + " - " + car.ModelYear + " eklendi");
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.Id == car.Id);
            _car.Remove(carToDelete);
            Console.WriteLine(carToDelete.Id + " - " + carToDelete.Description + " - " + carToDelete.ModelYear + " silindi");

        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            return _car.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Car> GetById(int carId)
        {
            return _car.Where(p => p.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car updateToCar = _car.SingleOrDefault(p => p.Id == car.Id);
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;
            updateToCar.CategoryId = car.CategoryId;
            Console.WriteLine(car.Id + " - " + car.Description + " - " + car.DailyPrice + " - " + " güncellendi");
        }
    }
}
