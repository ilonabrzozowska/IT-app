using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAp.ModelsView;
using WebAp.Models;
using WebAp.IRepositories;
using WebAp.Repositories;

namespace WebAp.Controllers
{
    public class HomeController : Controller
    {
        private WebApContext db = new WebApContext();

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