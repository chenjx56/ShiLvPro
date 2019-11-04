using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;

namespace DAL
{
    public class SqlNewsDAL : SqlBaseDAL<News>, INewsDAL
    {
        public IQueryable<News> GetNewsByName(string newsName)
        {
            IQueryable<News> listNews = db.News.Select(o => o).Where(p => p.Title.Contains(newsName));
            return listNews;
        }

        public IQueryable<News> GetNewsForIndex()
        {
            IQueryable<News> listNews = db.News.Select(o => o).OrderByDescending(p => p.CreateTime).Take(3);
            return listNews;
        }
    }
}
