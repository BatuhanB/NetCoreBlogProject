using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        //public List<BlogDto> GetBlogWithWriter(Expression<Func<Blog, bool>> filter)
        //{
        //    using (var c = new Context())
        //    {
        //        var result = from blog in c.Blogs.Where(filter)
        //                     join writer in c.Writers on blog.WriterID equals writer.WriterID
        //                     select new BlogDto { WriterID = writer.WriterID, WriterName = writer.WriterName, BlogID = blog.BlogID, BlogTitle = blog.BlogTitle };
        //        return result.ToList();
        //    }
        //}

        public List<Blog> GetListWithCategory()
        {
                using (var c = new Context())
                return c.Blogs.Include(c => c.Category).ToList();
        }
    }
}
