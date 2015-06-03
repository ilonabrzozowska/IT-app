using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer.Models;
using WebAp.IRepositories;
using WebAp.ModelsView;
using WebAp.Repositories;

namespace WebAp.Controllers
{
    public class MessageController : Controller
    {
        private ThreeTierContext db = new ThreeTierContext();
        public RepositoryFactory RepositoryFactory = new RepositoryFactory(new ThreeTierContext());

        // GET: Message
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                id = 1;
            }
            IClientRepository userRepository = RepositoryFactory.Create<IClientRepository>();
            RepositoryFactory factory = new RepositoryFactory(db);
            MessagePage page = userRepository.GetMessagePageByClient(userRepository.GetByID(id));
            return View(page);
        }
    }
}