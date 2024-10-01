using Microsoft.AspNetCore.Mvc;
using FusionTech.src.Services.Publisher;
using static FusionTech.src.DTO.PublisherDTO;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherService _publisherService;

        public PublisherController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        
        [HttpGet]
        public async Task<ActionResult<List<PublisherReadDto>>> GetAllPublishers()
        {
            var publishers = await _publisherService.GetAllAsync();
            return Ok(publishers);
        }

    
        [HttpGet("{id}")]
        public async Task<ActionResult<PublisherReadDto>> GetPublisherById(Guid id)
        {
            var publisher = await _publisherService.GetByIdAsync(id);
            if (publisher == null)
            {
                return NotFound();
            }
            return Ok(publisher);
        }


        [HttpPost]
        public async Task<ActionResult<PublisherReadDto>> CreatePublisher(PublisherCreateDto createDto)
        {
            var publisherCreated = await _publisherService.CreateOneAsync(createDto);
            return Created($"api/v1/Publisher/{publisherCreated.PublisherName}", publisherCreated);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePublisher(Guid id, PublisherUpdateDto updateDto)
        {
            var foundPublisher = await _publisherService.GetByIdAsync(id);
            if (foundPublisher == null)
            {
                return NotFound();
            }

            await _publisherService.UpdateOneAsync(id, updateDto);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePublisher(Guid id)
        {
            var foundPublisher = await _publisherService.GetByIdAsync(id);
            if (foundPublisher == null)
            {
                return NotFound();
            }

            await _publisherService.DeleteOneAsync(id);
            return NoContent();
        }
    }
}
