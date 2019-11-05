using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using IDAL;

namespace DALFactory
{
    public class DateAccess
    {
        private static string AssemblyName = ConfigurationManager.AppSettings["Path"].ToString();

        

        private static string db = ConfigurationManager.AppSettings["dbType"].ToString();
        public static INewsDAL GetNewsDAL()
        {
            string className = AssemblyName + "." + db + "NewsDAL";
            return (INewsDAL)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IArtefactsDAL GetArtefactsDAL()
        {
            string className = AssemblyName + "." + db + "ArtefactsDAL";
            return (IArtefactsDAL)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IEmergencysDAL GetEmergencysDAL()
        {
            string className = AssemblyName + "." + db + "EmergencysDAL";
            return (IEmergencysDAL)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IUserInfoDAL GetUserInfoDAL()
        {
            string className = AssemblyName + "." + db + "UserInfoDAL";
            return (IUserInfoDAL)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IUserDAL GetUserDAL()
        {
            string className = AssemblyName + "." + db + "UserDAL";
            return (IUserDAL)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
