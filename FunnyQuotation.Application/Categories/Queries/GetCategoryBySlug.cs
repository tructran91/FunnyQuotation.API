using AutoMapper;
using FunnyQuotation.Application.Categories.Queries.Dtos;
using FunnyQuotation.Application.Common.Interfaces.Repositories;
using FunnyQuotation.Domain.Entities;
using MediatR;

namespace FunnyQuotation.Application.Categories.Queries
{
    public class GetCategoryBySlugQuery : IRequest<CategoryDto>
    {
        public string Slug { get; set; }

        public GetCategoryBySlugQuery(string slug)
        {
            Slug = slug;
        }
    }

    public class GetCategoryBySlugHandle : IRequestHandler<GetCategoryBySlugQuery, CategoryDto>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryBySlugHandle(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDto> Handle(GetCategoryBySlugQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetCategoryBySlugAsync(request.Slug);
            category = (category == null) ? new Category() : category;

            return _mapper.Map<CategoryDto>(category);
        }
    }
}
