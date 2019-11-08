using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace ShiLv.WebUI.Controllers
{
    public class UserInfoController : Controller
    {
        UserBLL userInfoManager = new UserBLL();
        // GET: UserInfo
        public ActionResult Index()
        {
            return View();
        }
        #region 登录
        [HttpPost]
        public string Login([Bind(Include = "UserName,UserPwd")]string UserName,string UserPwd)
        {
            string data = null;
            try
            {
                var user = userInfoManager.Login(UserName, UserPwd);
                if (user != null)
                {
                    Session["UserName"] = user.UserName;
                    Session["UserImage"] = user.UserInfo.UserImage;
                    Session["NickName"] = user.UserInfo.NickName;
                    Session["UserCredit"] = user.UserInfo.UserCredit;
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
                data = "登录出错";
                return data;
            }
        }
        #endregion
        #region 注销
        [HttpPost]
        public string Logout()
        {
            Session["UserName"] = null;
            Session["UserImage"] = null;
            Session["NickName"] = null;
            Session["UserCredit"] = null;
            return "success";
        }
        #endregion
    }
}