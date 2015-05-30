using DataLayer.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace DataLayer.Models
{

    public class ThreeTierContext : DbContext
    {

        public ThreeTierContext()
           // : base("DefaultConnection")
           // : base("name=ThreeTier")
            : base("ThreeTier")
        {
            Database.SetInitializer<ThreeTierContext>(new ThreeTierInitializer());

        }

        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Item> Items { get; set; }

    }
}