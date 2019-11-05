using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DALFactory;
using IDAL;

namespace BLL
{
    public class UserBLL :BaseBLL<Users>
    {
        private IUserDAL UserDAL = DALFactory.DateAccess.GetUserDAL();
        public override void SetDal()
        {
            Dal = UserDAL;
        }
        public Users Login(string UserName, string UserPwd)
        {
            return UserDAL.GetModels(o => o.UserPwd == UserPwd && o.UserName == UserName).FirstOrDefault();
        }
    }
}
