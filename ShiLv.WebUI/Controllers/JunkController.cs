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
using System.Text.RegularExpressions;

namespace ShiLv.WebUI.Controllers
{
    public class JunkController : Controller
    {
        private ShiLvDBEntities db = new ShiLvDBEntities();
        JunkBLL junkBLL = new JunkBLL();
        JunkTypeBLL junkTypeBLL = new JunkTypeBLL();
        // GET: Junk
        public ActionResult Index(int ID = 0)
        {
            List<JunkType> list = junkTypeBLL.GetJunkTypeForTop().ToList();
            list.Insert(0, new JunkType() { ID = 0, TypeName = "全部分类" });
            var selectList = new SelectList(list, "ID", "TypeName", ID);
            ViewBag.selectList = selectList;
            return View();
        }

        /// <summary>
        /// 通过查询条件获取垃圾的视图
        /// </summary>
        /// <param name="page"></param>
        /// <param name="typeID"></param>
        /// <param name="junkName"></param>
        /// <returns></returns>
        public ActionResult GetJunksByPage(int? page,int typeID = 0,string junkName = null)
        {
            
            IQueryable<Junks> junks = null;
            if (typeID == 0)
            {
                if (junkName != null)
                {
                    junks = db.Junks.OrderByDescending(p => p.ID).Where(p=>p.JunksName.Contains(junkName));
                }
                else
                {
                    junks = db.Junks.OrderByDescending(p => p.ID);
                }
            }
            else
            {
                if (junkName != null)
                {
                    junks = db.Junks.OrderByDescending(p => p.ID).Where(p => p.JunkTypeId == typeID && p.JunksName.Contains(junkName));
                }
                else
                {
                    junks = db.Junks.OrderByDescending(p => p.ID).Where(p => p.JunkTypeId == typeID);
                }
                
            }
            
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            return View(junks.ToPagedList(pageNumber, pageSize));
        }
        
        public string SavePicture()
        {
            string result = "";
            HttpPostedFileBase imageName = Request.Files["image"];// 从前台获取文件
            string junkName = Request["junkName"];
            int junkType = Convert.ToInt32(Request["junkType"]);
            string userName = Request["userName"];
            string file = imageName.FileName;
            string fileFormat = file.Split('.')[file.Split('.').Length - 1]; // 以“.”截取，获取“.”后面的文件后缀
            Regex imageFormat = new Regex(@"^(bmp)|(png)|(gif)|(jpg)|(jpeg)"); // 验证文件后缀的表达式
            if (string.IsNullOrEmpty(file) || !imageFormat.IsMatch(fileFormat)) // 验证后缀，判断文件是否是所要上传的格式
            {
                result = "error";
            }
            else
            {
                string timeStamp = DateTime.Now.Ticks.ToString(); // 获取当前时间的string类型
                string firstFileName = timeStamp.Substring(0, timeStamp.Length - 4); // 通过截取获得文件名
                string imageStr = "Content/images/junk/"; // 获取保存图片的项目文件夹
                string uploadPath = Server.MapPath("~/" + imageStr); // 将项目路径与文件夹合并
                string pictureFormat = file.Split('.')[file.Split('.').Length - 1];// 设置文件格式
                string fileName = firstFileName + "." + fileFormat;// 设置完整（文件名+文件格式） 
                string saveFile = uploadPath + fileName;//文件路径
                imageName.SaveAs(saveFile);// 保存文件
                // 如果单单是上传，不用保存路径的话，下面这行代码就不需要写了！
                string image = "junk/" + fileName;// 设置数据库保存的路径
                Junks junk = new Junks()
                {
                    JunksName = junkName,
                    JunkImage = image,
                    JunkTypeId = junkType,
                    UserName = userName,
                    LikeNum = 0,
                    DislikeNum = 0
                };
                junkBLL.Add(junk);
                result = "success";
            }
            return result;
        }
    }
}