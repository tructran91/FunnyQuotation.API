using AutoMapper;
using FunnyQuotation.API.ViewModels;
using FunnyQuotation.Application.Categories.Commands;
using FunnyQuotation.Application.Categories.Queries;
using FunnyQuotation.Application.Categories.Queries.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FunnyQuotation.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CategoryController(ILogger<CategoryController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("get-categories")]
        public async Task<ActionResult> GetCategories()
        {
            var queryCate = new GetCategoriesQuery(new CategoryCriteriaDto { IsPublished = true });
            var categories = await _mediator.Send(queryCate);

            return Ok(categories);
        }

        [HttpGet("get-category")]
        public async Task<ActionResult> GetCategory(Guid id)
        {
            var queryCate = new GetCategoryByIdQuery(id);
            var categoryDto = await _mediator.Send(queryCate);

            return Ok(categoryDto);
        }

        [HttpPost("add-category")]
        public async Task<IActionResult> CreateCategory([FromBody] AddEditCategoryViewModel category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categoryDto = _mapper.Map<CategoryDto>(category);
            var queryCate = new AddCategoryQuery(categoryDto);
            var result = await _mediator.Send(queryCate);

            if (!result.Succeeded)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
