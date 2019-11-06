using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;

namespace BLL
{
    public class JunkBLL : BaseBLL<Junks>
    {
        private IJunkDAL junkDAL = DALFactory.DateAccess.GetJunkDAL();
        public override void SetDal()
        {
            Dal = junkDAL;
        }
    }
}
