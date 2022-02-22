using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context context = new Context();
        public void AddCategory(Category category)
        {
            context.Add(category);
            context.SaveChanges(true);
        }

        public void Delete(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category getById(int id)
        {
            return context.Categories.Find(id);
        }

        public Category GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
            return context.Categories.ToList();
        }

        public void RemoveCategory(Category category)
        {
            context.Remove(category);   
            context.SaveChanges(true);
        }

        public void Update(Category t)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            context.Update(category);
        }
    }
}
