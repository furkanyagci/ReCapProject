using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category brand)
        {
            _categoryDal.Add(brand);
        }

        public void Delete(Category brand)
        {
            _categoryDal.Delete(brand);
        }

        public void Update(Category brand)
        {
            _categoryDal.Update(brand);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(p => p.Id == id);
        }
    }
}
