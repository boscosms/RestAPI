using Walking.API.Models.Domain;

namespace Walking.API.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
        Task<Region> GetAsync(Guid Id);
    }
}
