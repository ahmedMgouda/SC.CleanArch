using SC.Repository.Entities;
using System.Data.Entity.ModelConfiguration;


namespace SC.Repository.Configurations
{
    public class SalonConfiguration : EntityTypeConfiguration<Salon>
    {
        public SalonConfiguration()
        {
            ToTable("Salons");
        }
    }
}
