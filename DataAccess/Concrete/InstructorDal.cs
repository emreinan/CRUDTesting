using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IGenericDal<Instructor>
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>()
            {
                new Instructor() {Id=1,Name="Engin",LastName="Demirog"}
            };
        }

        public void Add(Instructor entity)
        {
            instructors.Add(entity);
            Console.WriteLine("Instructor Added");
        }

       

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public Instructor GetById(int id)
        {
            Instructor entity = instructors.FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public void Delete(Instructor entity)
        {
            var removeItem = instructors.FirstOrDefault(entity => entity.Id == entity.Id);
            if (removeItem != null)
            {
                instructors.Remove(removeItem);
                Console.WriteLine("Instructor Remove");
            }

        }

        public void Update(Instructor entity)
        {
            var updateItem = instructors.FirstOrDefault(i => i.Id == entity.Id);
            if (updateItem != null)
            {
                updateItem.Name = entity.Name;
                updateItem.LastName = entity.LastName;
                Console.WriteLine("Instructor Update");
            }
        }
    }
}
