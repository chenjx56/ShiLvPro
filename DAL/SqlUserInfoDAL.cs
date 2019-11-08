using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;

namespace DAL
{
    class SqlUserInfoDAL:SqlBaseDAL<UserInfo>,IUserInfoDAL
    {
        private ShiLvDBEntities db = DbContextFactory.CreateDbContext();
        /// <summary>
        /// 获得排名前N个上传作品最多的用户
        /// </summary>
        /// <returns></returns>
        public IQueryable<UserInfo> GetBeforeUploadArtefactUsersForN(int n)
        {
            var users = from a in (from u in db.UserInfo
                                   join a in db.Artefacts on u.UserName equals a.Author
                                   group u by u into g
                                   select new
                                   {
                                       Users = g.Key,
                                       count = g.Count()
                                   }).OrderByDescending(
                        g => g.count)
                        select a.Users;
            return users;
        }
        public UserInfo GetUserInfosByArtefactId(int ArtefactsId)
        {
            var users = (from a in db.UserInfo
                         join b in db.Artefacts on a.UserName equals b.Author
                         where b.ID == 2
                         select a).SingleOrDefault();
            return users;
        }
    }
}
