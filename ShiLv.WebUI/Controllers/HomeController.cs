using BLL;
using Models;
using ShiLv.WebUI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ShiLv.WebUI.Controllers
{
    public class HomeController : Controller
    {
        NewsBLL newsBLL = new NewsBLL();
        ArtefactsBLL artefactsBLL = new ArtefactsBLL();
        EmergencysBLL emergencysBLL = new EmergencysBLL();
        public ActionResult Index()
        {
            HomeIndexViewModel hvm = new HomeIndexViewModel();
            hvm.Newlist1 = newsBLL.GetNewsForIndex();
            hvm.Artefacts1 = artefactsBLL.GetArtefactsForIndex();
            hvm.Emergencys1 = emergencysBLL.GetEmergencysForIndex();
            return View(hvm);
        }
    }
}