using SC.Repository.Entities;
using System.Data.Entity;

namespace SC.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("SCDataStore") { }

        public DbSet<Salon> Salons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
