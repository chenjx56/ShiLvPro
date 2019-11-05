using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NewsBLL : BaseBLL<News>
    {
        private INewsDAL newsDAL = DALFactory.DateAccess.GetNewsDAL();
        public override void SetDal()
        {
            Dal = newsDAL;
        }
        public IQueryable<News> GetNewsByName(string newsName)
        {
            return newsDAL.GetModels(p => p.Title.Contains(newsName));
        }
        public IQueryable<News> GetNewsForIndex()
        {
            return newsDAL.GetModels(o => o != null).OrderByDescending(p => p.CreateTime).Take(3);
        }
    }
}
