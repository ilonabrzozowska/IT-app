using Microsoft.Owin;
using Owin;
using System.Data.Entity;
using DataLayer.Models;

[assembly: OwinStartupAttribute(typeof(WebAp.Startup))]

namespace WebAp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.SetInitializer<ThreeTierContext>(new ThreeTierInitializer());
            //context.Database.Initialize(false);
            ConfigureAuth(app);
        }
    }
}
