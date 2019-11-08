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
        /// <summary>
        /// 获取首页展示的手工作品
        /// </summary>
        /// <returns></returns>
        public IQueryable<Artefacts> GetArtefactsForIndex()
        {
            return artefactsDAL.GetModels(o => o != null).OrderBy(p => p.ID).Take(6);
        }

        /// <summary>
        /// 通过分类获取作品
        /// </summary>
        /// <param name="type"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public IQueryable<Artefacts> GetTypeArtefactsForWorkHome(int type, int n = 0)
        {
            if (type >= 1 && type <= 3)
            {
                if (n > 0)
                {
                    return artefactsDAL.GetModels(o => o.ArtefactTypeID == type).OrderByDescending(p => p.ID).Take(n);
                }
                else return artefactsDAL.GetModels(o => o.ArtefactTypeID == type).OrderByDescending(p => p.ID);
            }
            else
            {
                if (n > 0)
                {
                    return artefactsDAL.GetModels(o => o != null).OrderByDescending(o => o.PublisheTime).Take(n);
                }
                else return artefactsDAL.GetModels(o => o != null).OrderByDescending(o => o.PublisheTime);
            }
        }

        /// <summary>
        /// 通过作品ID 查询作品
        /// </summary>
        /// <param name="id"></param>
        public Artefacts GetArtefactByArtefactID(int ArtefactID)
        {
            return artefactsDAL.GetArtefactByArtefactID(ArtefactID);
        }
    }
}
