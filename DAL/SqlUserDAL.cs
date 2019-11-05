using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;

namespace DAL
{
    public class SqlUserDAL : SqlBaseDAL<Users>,IUserDAL
    {
    }
}
