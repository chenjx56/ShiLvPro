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

        /// <summary>
        /// 获得排名前N个上传作品最多的用户
        /// </summary>
        /// <returns></returns>
        public IQueryable<UserInfo> GetBeforeUploadArtefactsUsersForN(int n)
        {
            return userInfoDAL.GetBeforeUploadArtefactUsersForN(n);
        }
        /// <summary>
        /// 通过作品ID获得发布用户
        /// </summary>
        /// <param name="ArtefactsId"></param>
        /// <returns></returns>
        public UserInfo GetUserInfosByArtefactId(int ArtefactsId)
        {
            return userInfoDAL.GetUserInfosByArtefactId(ArtefactsId);
        }
    }
}
