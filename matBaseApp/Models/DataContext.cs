using System.Configuration;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace vls.Models
{
    public class DataContext : IdentityDbContext<MyUser>
    {
        public DataContext()
            : base("DefaultConnection")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Configuration.LazyLoadingEnabled = true;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Migrations.Configuration>());
            base.OnModelCreating(modelBuilder);
        }
    }
}