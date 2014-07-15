using System.Web.Mvc;

namespace SqlSignalR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Status()
        {
            return View();
        }
    }
}