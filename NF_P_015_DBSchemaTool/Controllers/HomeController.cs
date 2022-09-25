using System.Web.Mvc;

namespace NF_P_015_DBSchemaTool.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}