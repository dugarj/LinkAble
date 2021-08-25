using LABOL;
using System;
using System.Collections.Generic;
using System.Text;

namespace LADAL
{
    public interface ICategoryDb
    {
        IEnumerable<Category> GetAll();
        Category GetById(int id);
        bool Create(Category category);
        bool Update(Category category);
        bool Delete(int id);
    }
    
    public class CategoryDb : ICategoryDb
    {
        LADbContext LADbContext;

        public CategoryDb(LADbContext _LADbContext)
        {
            LADbContext = _LADbContext;
        }

        public bool Create(Category category)
        {
            LADbContext.Add(category);
            LADbContext.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var category = LADbContext.Categories.Find(id);
            LADbContext.Remove<Category>(category);
            LADbContext.SaveChanges();
            return true;
        }

        public IEnumerable<Category> GetAll()
        {
            return LADbContext.Categories;
        }

        public Category GetById(int id)
        {
            var category = LADbContext.Categories.Find(id);
            return category;
        }

        public bool Update(Category category)
        {
            LADbContext.Update<Category>(category);
            LADbContext.SaveChanges();
            return true;
        }
    }
}
