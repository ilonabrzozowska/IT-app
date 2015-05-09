using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using Service.Models;
using System.Configuration;

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
                Database.SetInitializer<WebApContext>(new WebApInitializer());
            }
            else
            {
                Database.SetInitializer<WebApContext>(null);
            }

            //Database.SetInitializer<WebApContext>(new WebApInitializer());
        }
    }
}
