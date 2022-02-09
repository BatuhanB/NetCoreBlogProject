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
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddBlog(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void DeleteBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllListBlog()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetAllListBlogByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID==id);
        }

        public Blog GetBlogByID(int id)
        {
            throw new NotImplementedException();
        }
        public List<Blog> GetBlogListByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }

        public List<Blog> GetListBlog()
        {
            return _blogDal.GetAll();   
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
