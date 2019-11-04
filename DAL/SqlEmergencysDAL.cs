using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;

namespace DAL
{
    public class SqlEmergencysDAL : SqlBaseDAL<Emergencys>, IEmergencysDAL
    {
        public IQueryable<Emergencys> GetEmergencysForIndex()
        {
            var emerList = db.Emergencys.Select(o => o).OrderByDescending(p => p.publishTime).Distinct().Take(15);
            return emerList;
        }
        
    }
}
