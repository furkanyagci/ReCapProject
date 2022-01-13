using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        List<Car> GetAll();
        List<Car> GetAllBtCategoryId(int id);
        List<Car> GetByUnitPrice(decimal min, decimal max);

        // 8.Gün 1. Ödev 5.madde : GetCarsByBrandId , GetCarsByColorId servislerini yazınız.
        List<Car> GetCarsByBrandId(int id);

        List<Car> GetCarsByColorId(int id);

    }
}
