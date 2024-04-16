using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : IGenericDal<Course>
    {
        List<Course> courses;
        public CourseDal()
        {
            courses = new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    CategoryId = 1,
                    InstructorId = 1,
                    Name="C# + Angular",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id= 2,
                    CategoryId = 2,
                    InstructorId = 2,
                    Name="Java + React ",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id=3,
                    CategoryId = 3,
                    InstructorId = 3,
                    Name="C#",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id=4,
                    CategoryId = 4,
                    InstructorId = 4,
                    Name="JavaScript",
                    Description="Yazilim Gelistirme"
                },
               
            };
        }
        public void Add(Course entity)
        {
            courses.Add(entity);
            Console.WriteLine("Course Aded");
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course GetById(int id)
        {
            var course = courses.FirstOrDefault(c => c.Id == id);
            return course;
        }

        public void Delete(Course entity)
        {
            var removeItem = courses.FirstOrDefault(c => c.Id == entity.Id);
            if (removeItem != null)
            {
                courses.Remove(removeItem);
                Console.WriteLine("Course Remove");
            }
            Console.WriteLine("Check and try again");
        }

        public void Update(Course entity)
        {
            var updateItem = courses.FirstOrDefault(u => u.Id == entity.Id);
            if (updateItem != null)
            {
                updateItem.Name = entity.Name;
                updateItem.Description = entity.Description;
                updateItem.CategoryId = entity.CategoryId;
                updateItem.Id = entity.Id;
                Console.WriteLine("Course Updated");
            }
            Console.WriteLine("Check and try again");
        }
    }
}
