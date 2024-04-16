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
    public class InstructorManager : IGenericService<Instructor>
    {
        private readonly IGenericDal<Instructor> _instructorDal;

        public InstructorManager(IGenericDal<Instructor> instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor item)
        {
            _instructorDal.Add(item);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.GetById(id);
        }

        public void Delete(Instructor item)
        {
            _instructorDal.Delete(item);
        }

        public void Update(Instructor item)
        {
            _instructorDal.Update(item);
        }
    }
}
