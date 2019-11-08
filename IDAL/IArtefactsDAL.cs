using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
    public interface IArtefactsDAL : IBaseDAL<Artefacts>
    {
        /// <summary>
        /// 通过作品ID 查询作品
        /// </summary>
        /// <param name="id"></param>
        Artefacts GetArtefactByArtefactID(int id);
    }
}
