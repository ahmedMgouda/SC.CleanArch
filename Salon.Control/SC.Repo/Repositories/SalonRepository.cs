using SC.Core.Domain;
using SC.Core.Repo;

namespace SC.Repo
{
    public class SalonRepository : BaseRepository<Salon>, ISalonRepository
    {
        public SalonRepository(IDbFactory dbFactory) 
            : base(dbFactory) { }
    }
}
