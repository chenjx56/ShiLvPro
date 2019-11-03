using BLL;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ShiLv.WebUI.Controllers
{
    public class HomeController : Controller
    {
        NewsBLL newsBLL = new NewsBLL();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Test()
        {
            IQueryable<News> list = newsBLL.GetNewsByName("新");
            return View(list);
        }
    }
}