using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;
using System.Linq.Expressions;

namespace DAL
{
    public class SqlAdminDAL : SqlBaseDAL<Admins>,IAdminDAL
    {
    }
}
