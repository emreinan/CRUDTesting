using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : IGenericService<Category>
    {
        private readonly IGenericDal<Category> _genericDal;

        public CategoryManager(IGenericDal<Category> genericDal)
        {
            _genericDal = genericDal;
        }

        public void Add(Category item)
        {
            _genericDal.Add(item);
        }

        public List<Category> GetAll()
        {
            return _genericDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _genericDal.GetById(id);
        }

        public void Delete(Category item)
        {
            _genericDal.Delete(item);
        }

        public void Update(Category item)
        {
            _genericDal.Update(item);
        }
    }
}
