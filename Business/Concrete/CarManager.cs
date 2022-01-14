using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                throw new NotImplementedException("Araba ismi minimum 2 karakter olmalıdır. - Araba günlük fiyatı 0'dan büyük olmalıdır.");
            }
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllBtCategoryId(int id)
        {
            return _carDal.GetAll(p => p.CategoryId == id);
        }

        public List<Car> GetByUnitPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(p => p.Id == id);
        }

        public List<Car> GetAllByCategoryId(int id)
        {
            return _carDal.GetAll(p => p.CategoryId == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }



        //Aşağıdaki kodlara gerek kalmadı. Sistemi Generic design pattern'e çevirdik.
        //public void Add(Car car)
        //{
        //    _carDal.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    _carDal.Delete(car);
        //}

        //public List<Car> GetAll()
        //{
        //    return _carDal.GetAll();
        //}

        //public List<Car> GetAllByCategory(int categoryId)
        //{
        //    return _carDal.GetAllByCategory(categoryId);
        //}

        //public List<Car> GetById(int carId)
        //{
        //    return _carDal.GetById(carId);
        //}

        //public void Update(Car car)
        //{
        //    _carDal.Update(car);
        //}
    }
}
