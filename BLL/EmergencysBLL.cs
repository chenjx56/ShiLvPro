using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;

namespace BLL
{
    public class EmergencysBLL : BaseBLL<Emergencys>
    {
        private IEmergencysDAL emergencysDAL = DALFactory.DateAccess.GetEmergencysDAL();
        public override void SetDal()
        {
            Dal = emergencysDAL;
        }
        public IQueryable<Emergencys> GetEmergencysForIndex()
        {
            return emergencysDAL.GetModels(o => o != null).OrderByDescending(p => p.publishTime).Distinct().Take(15);
        }
    }
}
