using Walking.API.Data;
using Walking.API.Models.Domain;

namespace Walking.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly DataContext _context;

        public RegionRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Region> GetAll()
        {
          return _context.Regions.ToList();
        }
    }
}
