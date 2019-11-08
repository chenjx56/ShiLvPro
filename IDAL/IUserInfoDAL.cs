using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
    public interface IUserInfoDAL :IBaseDAL<UserInfo>
    {
        /// <summary>
        /// 获得排名前N个上传作品最多的用户
        /// </summary>
        /// <returns></returns>
        IQueryable<UserInfo> GetBeforeUploadArtefactUsersForN(int n);
        /// <summary>
        /// 通过作品ID查询用户
        /// </summary>
        /// <param name="ArtefactsId"></param>
        /// <returns></returns>
        UserInfo GetUserInfosByArtefactId(int ArtefactsId);
    }
}
