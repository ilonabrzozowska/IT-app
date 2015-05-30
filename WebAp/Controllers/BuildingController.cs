using System.Web.Mvc;
using WebAp.ModelsView;
using WebAp.Repositories;
using WebAp.IRepositories;
using DataLayer.Models;
using DataLayer;

namespace WebAp.Controllers
{
    public class BuildingController : Controller
    {
      //  private ThreeTierContext ddb = new ThreeTierContext();


        private ThreeTierContext db = new ThreeTierContext();
        public RepositoryFactory RepositoryFactory = new RepositoryFactory(new ThreeTierContext());


        // GET: Building
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                id = 1;
            }
           // List<Client> lst = tbl_memberMaster_services.GetAllUsers();

           // return View(lst);
            IClientRepository userRepository = RepositoryFactory.Create<IClientRepository>();
            RepositoryFactory factory = new RepositoryFactory(db);
            BuildingPage page = userRepository.GetBuildingPageByClient(userRepository.GetByID(id));
            return View(page);
        }
    }
}