using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Models;

namespace BLL
{
    public class UserInfoBLL : BaseBLL<UserInfo>
    {
        private IUserInfoDAL userInfoDAL = DALFactory.DateAccess.GetUserInfoDAL();
        public override void SetDal()
        {
            Dal = userInfoDAL;
        }
    }
}
