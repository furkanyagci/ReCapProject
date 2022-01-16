using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAll();
        Car GetById(int id);
        List<Car> GetAllByCategoryId(int id);
        List<Car> GetByUnitPrice(decimal min, decimal max);

        // 8.Gün 1. Ödev 5.madde : GetCarsByBrandId , GetCarsByColorId servislerini yazınız.
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);

        List<CarDetailDto> GetCarDetails();

    }
}
