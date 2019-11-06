using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;
using System.Web.Script.Serialization;
using System.Text;
using PagedList;

namespace ShiLv.WebUI.Controllers
{
    public class JunkController : Controller
    {
        private ShiLvDBEntities db = new ShiLvDBEntities();
        JunkBLL junkBLL = new JunkBLL();
        JunkTypeBLL junkTypeBLL = new JunkTypeBLL();
        // GET: Junk
        public ActionResult Index()
        {
            var typeList = junkTypeBLL.GetJunkTypeForTop();
            return View(typeList.ToList());
        }
        public ActionResult Test(int? page)
        {//, bool jqueryUnobtrusive = false
            var junks = db.Junks.OrderByDescending(p => p.ID);
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            //ViewBag.jqueryUnobtrusive = jqueryUnobtrusive;
            return View(junks.ToPagedList(pageNumber, pageSize));
        }
    }
}