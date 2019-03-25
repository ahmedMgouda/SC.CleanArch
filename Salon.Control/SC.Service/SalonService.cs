using SC.Core.Repo;
using SC.Core.Service;

namespace SC.Service
{
    public class SalonService : ISalonService
    {
        private readonly ISalonRepository _salonRepository;

        public SalonService(ISalonRepository salonRepository)
        {
            _salonRepository = salonRepository;
        }


    }
}
