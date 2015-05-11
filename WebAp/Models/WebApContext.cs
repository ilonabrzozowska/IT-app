using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Optimization;
using System.Web.Routing;
using WebAp.Models;
//using Service.Models;
using System.Configuration;

namespace WebAp.Models
{
    public class WebApContext : DbContext
    {
        public WebApContext()
            : base("DefaultConnection")
		{
			Database.SetInitializer<WebApContext>(new WebApInitializer());
		}
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemDate> ItemDates { get; set; }

    }
}