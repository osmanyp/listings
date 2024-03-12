using AutoMapper;
using Demo.Listings.Domain.Interfaces;
using Demo.Listings.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Listings.Infrastructure.DataAccess.EF
{
    internal class ListingsRepository(ListingsDbContext listingsDbContext, IMapper mapper) : IListingsRepository
    {
        private readonly IMapper mapper = mapper;
        private readonly ListingsDbContext listingsDbContext = listingsDbContext;

        public async Task<Listing> GetAsync(int id)
        {
            var listing = await listingsDbContext.Listings.FindAsync(id);
            return mapper.Map<Listing>(listing);
        }

        public async Task<IEnumerable<Listing>> GetAllAsync()
        {
            var result = await listingsDbContext.Listings.ToListAsync();
            return mapper.Map<IEnumerable<Listing>>(result);
        }

        public async Task SaveAsync(Listing listing)
        {
            var entity = mapper.Map<Entities.Listing>(listing);
            if (listing.Id is null || listing.Id == 0)
            {
                await listingsDbContext.Listings.AddAsync(entity);
            } 
            else
            {
                listingsDbContext.Entry(entity).State = EntityState.Modified;
            }

            await listingsDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await listingsDbContext.Listings.FindAsync(id);

            if (entity is null)
                return;

            listingsDbContext.Listings.Remove(entity);
            await listingsDbContext.SaveChangesAsync();
        }
    }
}