using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace ShiLv.WebUI.Controllers
{
    public class AdminController : Controller
    {
        AdminBLL adminBLL = new AdminBLL();
        // GET: Admin
        public ActionResult Index()
        {
            if(Session["CurrentAdmin"] != null)
            {
                return View();
            }
            else
            {
                return View("Login");
            }
        }
        
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="AdminPwd"></param>
        /// <returns></returns>
        [HttpPost]
        public string Login([Bind(Include = "ID,AdminPwd")]string ID,string AdminPwd)
        {
            string data = null;
            try
            {
                var admin = adminBLL.Login(Convert.ToInt32(ID), AdminPwd);
                if (admin != null)
                {
                    Session["AdminID"] = admin.ID;
                    Session["AdminName"] = admin.AdminPwd;
                    Session["AdminNickName"] = admin.NickName;
                    data = "登录成功";
                }
                else
                {
                    data = "登录失败";
                }
                return data;
            }
            catch (Exception)
            {
                data = "登录错误";
                return data;

            }
            
        }

        /// <summary>
        /// 注销
        /// </summary>
        public void logout()
        {
            Session["AdminID"] = null;
            Session["AdminName"] = null;
            Session["AdminNickName"] = null;
        }
    }
}