using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;

namespace BLL
{
    public class AdminBLL : BaseBLL<Admins>
    {
        private IAdminDAL adminDAL = DALFactory.DateAccess.GetAdminDAL();
        public override void SetDal()
        {
            Dal = adminDAL;
        }
        public Admins Login(int AdminID,string AdminPwd)
        {
            return adminDAL.GetModels(o => o.ID == AdminID && o.AdminPwd == AdminPwd).FirstOrDefault();
        }
    }
}
