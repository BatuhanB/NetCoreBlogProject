﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
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

        public List<Blog> GetAllListBlog()
        {
            return _blogDal.GetListWithCategory();
        }
        public List<Blog> GetListWithCategoryByWriterBm(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }

        public List<Blog> GetAllListBlogByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }

        public List<Blog> GetBlogListByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }

        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetAll().Take(3).ToList();
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
           _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }

        public List<Blog> GetListT()
        {
            return _blogDal.GetAll();
        }

        public Blog GetTByID(int id)
        {
            return _blogDal.Get(id);
        }

        //public List<BlogDto> GetBlogWithWriter(int id)
        //{
        //    var deneme = _blogDal.GetBlogWithWriter(x => x.WriterID == id);
        //    return deneme;

        //}
    }
}
