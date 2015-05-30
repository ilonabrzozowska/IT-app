using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using System.Configuration;
using DataLayer.Models;

namespace WebAp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            if (bool.Parse(ConfigurationManager.AppSettings["CreateDatabase"]))
            {
                Database.SetInitializer<ThreeTierContext>(new ThreeTierInitializer());
            }
            else
            {
                Database.SetInitializer<ThreeTierContext>(null);
            }

            //Database.SetInitializer<WebApContext>(new WebApInitializer());
        }
    }
}
