using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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
