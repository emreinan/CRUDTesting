
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System.Security.Cryptography;



CourseManager courseManager = new CourseManager(new CourseDal());

Console.WriteLine("GetALL");
List<Course> courses = courseManager.GetAll();
foreach (Course course in courses)
{
    Console.WriteLine(course.Name+course.Description);
}

Console.WriteLine("Add");
courseManager.Add(new Course { Id = 5, Name = "BlockChain" });
foreach (Course course in courses)
    Console.WriteLine(course.Id+course.Name);

Console.WriteLine("GetById");
var getById = courseManager.GetById(5);
Console.WriteLine(getById.Name+ " " + getById.Id + " " +getById.Description);

Console.WriteLine("Update");

courseManager.Update(new Course { Description = "chanced", Id = 5, Name = "AutoCad" });
Console.WriteLine(getById);

Console.WriteLine("Delete");

courseManager.Delete(getById);
