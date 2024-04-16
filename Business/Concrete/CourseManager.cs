using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : IGenericService<Course>
    {
        private readonly IGenericDal<Course> _courseDal;

        public CourseManager(IGenericDal<Course> courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course item)
        {
            _courseDal.Add(item);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public void Delete(Course item)
        {
            _courseDal.Delete(item);
        }

        public void Update(Course item)
        {
            _courseDal.Update(item);
        }

        
    }
}
