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
        public void Add(Car product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car product)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList(); //Arkda planda bize Select * from Product döndürür. Ternary ifyazdık eğer filtre null ise Product tablosunu lit halinde verecek filtre null değilse filtreleyip verecek.
            }
        }

        public void Update(Car product)
        {
            throw new NotImplementedException();
        }
    }
}
