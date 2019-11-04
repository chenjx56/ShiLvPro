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
        public IQueryable<Artefacts> GetArtefactsForIndex()
        {
            IQueryable<Artefacts> listArtefacts = db.Artefacts.Select(o => o).OrderBy(p => p.ID).Take(6);
            return listArtefacts;
        }
    }
}
