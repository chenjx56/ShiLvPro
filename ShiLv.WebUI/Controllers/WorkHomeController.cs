using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShiLv.WebUI.Models;
using BLL;
using Models;

namespace ShiLv.WebUI.Controllers
{
    public class WorkHomeController : Controller
    {
        // GET: WorkHome
        ArtefactsBLL artefactsBLL = new ArtefactsBLL();
        UserInfoBLL userInfoBLL = new UserInfoBLL();
        // GET: WorkHome
        public ActionResult Index()
        {
            WorkHomeViewModel hvm = new WorkHomeViewModel();
            hvm.HandArtefacts = artefactsBLL.GetTypeArtefactsForWorkHome(2, 10);
            hvm.NatureArtefacts = artefactsBLL.GetTypeArtefactsForWorkHome(1, 10);
            hvm.AnimalArtefacts = artefactsBLL.GetTypeArtefactsForWorkHome(3, 10);
            hvm.UserInfo = userInfoBLL.GetBeforeUploadArtefactsUsersForN(7);
            return View(hvm);
        }
        [HttpPost]
        public ActionResult GetWorkDetails(int ArtefactsID = 0)
        {
            DetailsWorkPartialViewModel dvm = new DetailsWorkPartialViewModel();
            if (ArtefactsID != 0)
            {
                dvm.Artefacts = artefactsBLL.GetArtefactByArtefactID(ArtefactsID);
                dvm.UserInfo = userInfoBLL.GetUserInfosByArtefactId(ArtefactsID);
                return PartialView(dvm);
            }
            else
            {
                return new EmptyResult();
            }
        }
    }
}