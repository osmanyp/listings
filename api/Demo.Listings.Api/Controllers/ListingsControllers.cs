using AutoMapper;
using Demo.Listings.Api.Dtos;
using Demo.Listings.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Listings.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListingsController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly ILogger<ListingsController> logger;
        private readonly ListingsService listingsService;

        public ListingsController(ListingsService listingsService,
            IMapper mapper,
            ILogger<ListingsController> logger)
        {
            this.mapper = mapper;
            this.logger = logger;
            this.listingsService = listingsService;
        }

        [HttpGet]
        [Route("/listings/{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var result = await listingsService.listingsRepository.GetAsync(id);
            if (result is null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var result = await listingsService.listingsRepository.GetAllAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateListingReq listingReq)
        {
            var model = mapper.Map<Domain.Models.Listing>(listingReq);
            await listingsService.SaveAsync(model);
            return Created();
        }

        [HttpDelete]
        [Route("/listings/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await listingsService.Delete(id);
            return NoContent();
        }
    }

}