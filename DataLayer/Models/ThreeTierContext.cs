using DataLayer.Models;
using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DataLayer.Models
{

  //  public class ThreeTierContext : DbContext
    public class ThreeTierContext : IdentityDbContext<ApplicationUser>
    {

        public ThreeTierContext()
            // : base("DefaultConnection")
            // : base("name=ThreeTier")
            : base("ThreeTier", throwIfV1Schema: false)
        {
            Database.SetInitializer<ThreeTierContext>(new ThreeTierInitializer());

        }

        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ExternalLoginConfirmationViewModel> ExternalLoginConfirmationViewModels { get; set; }
        public virtual DbSet<ManageUserViewModel> ManageUserViewModels { get; set; }
        public virtual DbSet<LoginViewModel> LoginViewModels { get; set; }
        public virtual DbSet<RegisterViewModel> RegisterViewModels { get; set; }
        public virtual DbSet<ResetPasswordViewModel> ResetPasswordViewModels { get; set; }
        public virtual DbSet<ForgotPasswordViewModel> ForgotPasswordViewModels { get; set; }

        public static ThreeTierContext Create()
        {
            return new ThreeTierContext();
        }
    }

}