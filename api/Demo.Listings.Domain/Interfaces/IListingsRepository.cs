using Demo.Listings.Domain.Models;

namespace Demo.Listings.Domain.Interfaces
{
    public interface IListingsRepository
    {
        Task<Listing> GetAsync(int id);
        Task<IEnumerable<Listing>> GetAllAsync();
        Task SaveAsync(Listing listing);
        Task DeleteAsync(int id);
    }       
}