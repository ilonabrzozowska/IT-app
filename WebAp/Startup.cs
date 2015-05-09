using Microsoft.Owin;
using Owin;
using System.Data.Entity;
using Service.Models;



[assembly: OwinStartupAttribute(typeof(WebAp.Startup))]

namespace WebAp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.SetInitializer<WebApContext>(new WebApInitializer());
            //context.Database.Initialize(false);
            ConfigureAuth(app);
        }
    }
}
