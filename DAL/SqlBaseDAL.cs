using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Models;

namespace DAL
{
    public class SqlBaseDAL<T> where T : class, new()
    {
        public ShiLvDBEntities db = DbContextFactory.CreateDbContext();

        public void Add(T t)
        {
            db.Set<T>().Add(t);
            db.SaveChanges();
        }

        public void Remove(T t)
        {
            db.Set<T>().Remove(t);
            db.SaveChanges();
        }

        public void Update(T t)
        {
            db.Entry<T>(t).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
