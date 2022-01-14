using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join ct in context.Categories
                             on c.CategoryId equals ct.Id
                             join col in context.Colors
                             on c.ColorId equals col.Id
                             join br in context.Brands
                             on c.BrandId equals br.Id
                             select new CarDetailDto { CarId = c.Id, CarName = c.CarName, BrandName = br.Name, ModelYear = c.ModelYear, DailyPrice = c.DailyPrice, ColorName = col.Name, CategoryName = ct.CategoryName };

                return result.ToList();
            }
        }
    }
}
