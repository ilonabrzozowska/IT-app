using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer.Models;
using WebAp.Models;
using WebAp.ModelsView;
using WebAp.Repositories;
using WebAp.IRepositories;

namespace WebAp.Controllers
{
    public class BillController : Controller
    {
        private ThreeTierContext db = new ThreeTierContext();
        public RepositoryFactory RepositoryFactory = new RepositoryFactory(new ThreeTierContext());


        // GET: Bill
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                id = 1;
            }

            IClientRepository userRepository = RepositoryFactory.Create<IClientRepository>();
            RepositoryFactory factory = new RepositoryFactory(db);
            BillPage page = userRepository.GetBillPageByClient(userRepository.GetByID(id));
            return View(page);
        }
    }
}