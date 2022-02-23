using System;
using System.Collections.Generic;
using EntityLayer.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Dtos;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
        List<Blog> GetListWithCategoryByWriter(int id);
        //List<BlogDto> GetBlogWithWriter(Expression<Func<Blog, bool>> filter);
    }
}
