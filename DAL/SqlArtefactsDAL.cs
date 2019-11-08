using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;

namespace DAL
{
    public class SqlArtefactsDAL : SqlBaseDAL<Artefacts>, IArtefactsDAL
    {
        private ShiLvDBEntities db = DbContextFactory.CreateDbContext();

        /// <summary>
        /// 通过作品ID 查询作品
        /// </summary>
        /// <param name="id"></param>
        public Artefacts GetArtefactByArtefactID(int id)
        {
            return (from a in db.Artefacts
                    where a.ID == id
                    select a).FirstOrDefault();
        }
    }
}
