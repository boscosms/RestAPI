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

        public async Task<Region> GetAsync(Guid id)
        {
            return await _context.Regions.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
