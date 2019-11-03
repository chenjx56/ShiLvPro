using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class BaseBLL<T> where T : class, new()
    {
        public BaseBLL()
        {
            SetDal();
        }

        public abstract void SetDal();

        public IBaseDAL<T> Dal { get; set; }

        public void Add(T t)
        {
            Dal.Add(t);
        }
        public void Delete(T t)
        {
            Dal.Remove(t);
        }
        public void Update(T t)
        {
            Dal.Update(t);
        }
    }
}
