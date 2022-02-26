using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            this.blogDal = blogDal;
        }
        public void AddBlog(Blog blog)
        {
            blogDal.Insert(blog);
        }

        public List<Blog> GetAllBlogs()
        {
            return blogDal.GetAll();
        }

        public Blog GetBlogByID(int id)
        {
            return blogDal.GetByID(id);
        }

        public void RemoveBlog(Blog blog)
        {
            blogDal.Delete(blog);
        }

        public void UpdateBlog(Blog blog)
        {
            blogDal.Update(blog);
        }
    }
}
