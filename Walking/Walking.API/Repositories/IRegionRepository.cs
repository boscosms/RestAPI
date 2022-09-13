using Walking.API.Models.Domain;

namespace Walking.API.Repositories
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAll();
    }
}
