using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IBaseDAL<T>
    {
        void Add(T t);
        void Update(T t);
        void Remove(T t);
    }
}
