using Microsoft.AspNetCore.Mvc;
using Yourttoo.DTOs.Web.DTOs.Tagging;
using Yourttoo.DTOs.Web.Requests.Tagging;
using Yourttoo.DTOs.Base;

namespace Yourttoo.DTOs.Controllers
{
    /// <summary>
    /// Controller to manage tag categories
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class TagCategoryController : ControllerBase
    {
        private readonly ILogger<TagCategoryController> _logger;

        public TagCategoryController(ILogger<TagCategoryController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets all tag categories
        /// </summary>
        /// <returns>List of tag categories</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<TagCategoryDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<TagCategoryDto>>> GetAll()
        {
            try
            {
                _logger.LogInformation("Getting all tag categories");

                // TODO: Implement business logic to get categories
                var categories = new List<TagCategoryDto>();

                return Ok(categories);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting tag categories");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        /// <summary>
        /// Gets a tag category by its ID
        /// </summary>
        /// <param name="id">Category ID</param>
        /// <returns>Found tag category</returns>
        [HttpGet("{id:guid}")]
        [ProducesResponseType(typeof(TagCategoryDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<TagCategoryDto>> GetById(Guid id)
        {
            try
            {
                _logger.LogInformation("Getting tag category with ID: {Id}", id);

                // TODO: Implement business logic to get category by ID
                var category = new TagCategoryDto { Id = id };

                if (category == null)
                {
                    return NotFound($"Category with ID {id} not found");
                }

                return Ok(category);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting tag category with ID: {Id}", id);
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        /// <summary>
        /// Creates a new tag category
        /// </summary>
        /// <param name="apiRequest">API request containing category data</param>
        /// <returns>Created category</returns>
        [HttpPost]
        [ProducesResponseType(typeof(TagCategoryDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<TagCategoryDto>> Create([FromBody] ApiRequest<CreateTagCategoryRequest> apiRequest)
        {
            try
            {
                _logger.LogInformation("Creating new tag category via API request");

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (!apiRequest.IsValid())
                {
                    return BadRequest("Invalid API request");
                }

                if (apiRequest.Payload == null)
                {
                    return BadRequest("Request payload is required");
                }

                var request = apiRequest.Payload;
                _logger.LogInformation("Creating new tag category with code: {Code}", request.Code);

                // TODO: Implement business logic to create the category
                var category = new TagCategoryDto
                {
                    Id = Guid.NewGuid(),
                    Code = request.Code,
                    Name = request.Name,
                    Description = request.Description,
                    Filter = request.Filter,
                    CreatedAt = DateTime.UtcNow,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow
                };

                return CreatedAtAction(nameof(GetById), new { id = category.Id }, category);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating tag category");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        /// <summary>
        /// Updates an existing tag category
        /// </summary>
        /// <param name="id">Category ID</param>
        /// <param name="apiRequest">API request containing updated category data</param>
        /// <returns>Updated category</returns>
        [HttpPut("{id:guid}")]
        [ProducesResponseType(typeof(TagCategoryDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<TagCategoryDto>> Update(Guid id, [FromBody] ApiRequest<CreateTagCategoryRequest> apiRequest)
        {
            try
            {
                _logger.LogInformation("Updating tag category with ID: {Id}", id);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (!apiRequest.IsValid())
                {
                    return BadRequest("Invalid API request");
                }

                if (apiRequest.Payload == null)
                {
                    return BadRequest("Request payload is required");
                }

                var request = apiRequest.Payload;

                // TODO: Implement business logic to update the category
                var category = new TagCategoryDto
                {
                    Id = id,
                    Code = request.Code,
                    Name = request.Name,
                    Description = request.Description,
                    Filter = request.Filter,
                    CreatedAt = DateTime.UtcNow,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow
                };

                return Ok(category);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating tag category with ID: {Id}", id);
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        /// <summary>
        /// Deletes a tag category
        /// </summary>
        /// <param name="id">Category ID</param>
        /// <returns>No content</returns>
        [HttpDelete("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                _logger.LogInformation("Deleting tag category with ID: {Id}", id);

                // TODO: Implement business logic to delete the category

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting tag category with ID: {Id}", id);
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        /// <summary>
            /// Gets tag categories that have filtering enabled
        /// </summary>
        /// <returns>List of categories with filtering enabled</returns>
        [HttpGet("filterable")]
        [ProducesResponseType(typeof(List<TagCategoryDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<TagCategoryDto>>> GetFilterable()
        {
            try
            {
                _logger.LogInformation("Getting tag categories with filtering enabled");

                // TODO: Implement business logic to get filterable categories
                var filterableCategories = new List<TagCategoryDto>();

                return Ok(filterableCategories);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting filterable tag categories");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
} 