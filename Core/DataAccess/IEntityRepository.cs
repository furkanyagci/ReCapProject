using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//Expression : Filtreleme işlemi yapmak için kullanılıyor. p=>p.ProductId=2 getir demek yerine Expression kullanarak filtreleme yapılabilir.Bu sayede Kategoriye göre getiryada Id'ye göre getirmek için ayrı ayrı metotlar yazman gerekmeyecek.
        T Get(Expression<Func<T, bool>> filter = null);//ID ile veri almak için bunu yazdık.Örneğin bir kişinin hesap bilgileri için kullanılabilir.

        void Add(T product);
        void Update(T product);
        void Delete(T product);
    }
}
