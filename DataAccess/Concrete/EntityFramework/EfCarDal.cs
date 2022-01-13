using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car car)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                context.Cars.Add(car);
                context.SaveChanges();
            }
        }

        public void Delete(Car car)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                context.Cars.Remove(context.Cars.SingleOrDefault(p=>p.Id==car.Id));//context.Cars.Remove(car); buşekilde yazarsak silme işlemi olmaz. Db deki alan ile tam eşleştirmemiz gerekir o yüzden car.Id ile eşleştirdik
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                return context.Cars.SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList(); //Arkda planda bize Select * from Car döndürür. Ternary ifyazdık eğer filtre null ise Car tablosunu lit halinde verecek filtre null değilse filtreleyip verecek.
            }
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
