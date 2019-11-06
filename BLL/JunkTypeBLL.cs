using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;

namespace BLL
{
    public class JunkTypeBLL:BaseBLL<JunkType>
    {
        private IJunkTypeDAL junkTypeDAL = DALFactory.DateAccess.GetJunkTypeDAL();

        public override void SetDal()
        {
            Dal = junkTypeDAL;
        }
        public IQueryable<JunkType> GetJunkTypeForTop()
        {
            return junkTypeDAL.GetModels(o => o != null).Select(o => o);
        }
    }
}
