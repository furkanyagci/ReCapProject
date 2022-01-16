using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category brand);
        void Delete(Category brand);
        void Update(Category brand);
        List<Category> GetAll();
        Category GetById(int id);
    }
}
