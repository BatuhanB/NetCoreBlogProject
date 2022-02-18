using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    internal interface IBlogService:IGenericService<Blog>
    {
        List<Blog> GetAllListBlog();
        List<Blog> GetAllListBlogByWriter(int id);
        //List<BlogDto> GetBlogWithWriter(int id);
    }
}
