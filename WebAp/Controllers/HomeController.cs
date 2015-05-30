using System.Web.Mvc;
using DataLayer.Models;



namespace WebAp.Controllers
{
    public class HomeController : Controller
    {
        private ThreeTierContext db = new ThreeTierContext();

        public ActionResult Index()
        {
          //  RepositoryFactory factory = new RepositoryFactory(db);
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
    }
}