﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAp.Models;
using WebAp.ModelsView;
using WebAp.Repositories;
using WebAp.IRepositories;

namespace WebAp.Controllers
{
    public class BillController : Controller
    {
        private WebApContext db = new WebApContext();
        public RepositoryFactory RepositoryFactory = new RepositoryFactory(new WebApContext());


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