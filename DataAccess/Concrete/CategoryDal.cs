using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class CategoryDal : IGenericDal<Category>
    {
        List<Category> _categories;
        public CategoryDal() 
        {
            _categories = new List<Category>
            {
                new Category() {Id=1,Name="Backend"},
                new Category() {Id=2,Name="Frontend"},
                new Category() {Id=3,Name="Ai"},
            };
        }
        public void Add(Category item)
        {
            _categories.Add(item);
            Console.WriteLine("Category Added.");
        }

        public void Delete(Category entity)
        {
            var deleteItem = _categories.FirstOrDefault(c => c.Id == entity.Id);
            if (deleteItem != null)
            {
                _categories.Remove(deleteItem);
                Console.WriteLine("Category removed.");
                
            }
            Console.WriteLine("Check id try again.");
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            var selectedItem = _categories.FirstOrDefault(c=>c.Id == id);
            return selectedItem;

        }

        public void Update(Category item)
        {
            var selectedItem = _categories.FirstOrDefault(c => c.Id == item.Id);
            if (selectedItem != null)
            {
                selectedItem.Name=item.Name;
                Console.WriteLine("Category updated!");
                
            }
            Console.WriteLine("Check id try again.");
        }
    }
}
