using Demo.Listings.Domain.Interfaces;
using Demo.Listings.Domain.Models;

namespace Demo.Listings.Domain.Services
{
    public class ListingsService
    {
        public IListingsRepository listingsRepository;

        public ListingsService(IListingsRepository listingsRepository)
        {
            this.listingsRepository = listingsRepository;
        }

        public async Task<Listing> GetAsync(int id)
        {
            var listing = await listingsRepository.GetAsync(id);
            return listing;
        }

        public async Task<IEnumerable<Listing>> GetAllAsync()
        {
            var listings = await listingsRepository.GetAllAsync();
            return listings;
        }

        public async Task SaveAsync(Listing listing)
        {
            await listingsRepository.SaveAsync(listing);
        }

        public async Task Delete(int id)
        {
            await listingsRepository.DeleteAsync(id);
        }
    }
}

