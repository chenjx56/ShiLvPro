using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ArtefactsBLL : BaseBLL<Artefacts>
    {
        private IArtefactsDAL artefactsDAL = DALFactory.DateAccess.GetArtefactsDAL();
        public override void SetDal()
        {
            Dal = artefactsDAL;
        }
        public IQueryable<Artefacts> GetArtefactsForIndex()
        {
            return artefactsDAL.GetArtefactsForIndex();
        }
    }
}
