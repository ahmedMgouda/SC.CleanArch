using SC.Core.DTO;
using SC.Core.Repo;

namespace SC.Repository.Repositories
{
    public class SalonRepository : BaseRepository<SalonDto>, ISalonRepository
    {
        public SalonRepository(AppDbContext context) 
            : base(context)
        {

        }
    }
}
