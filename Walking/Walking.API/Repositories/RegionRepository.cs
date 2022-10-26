using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
          return await _context.Regions.ToListAsync();
        }
    }
}
