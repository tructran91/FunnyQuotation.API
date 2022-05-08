using FunnyQuotation.Application.Categories.Queries.Dtos;
using FunnyQuotation.Application.Common.Interfaces;
using FunnyQuotation.Application.Common.Interfaces.Repositories;
using MediatR;

namespace FunnyQuotation.Application.Categories.Queries
{
    public class GetCategoriesQuery : IRequest<List<CategoriesDto>>
    {
        public CategoryCriteriaDto Criteria { get; set; }

        public GetCategoriesQuery(CategoryCriteriaDto criteria)
        {
            Criteria = criteria;
        }
    }

    public class GetCategoriesHandler : IRequestHandler<GetCategoriesQuery, List<CategoriesDto>>
    {
        private readonly IMemoryCacheManager _memoryCacheManager;
        private readonly ICategoryRepository _categoryRepository;

        public GetCategoriesHandler(IMemoryCacheManager memoryCacheManager,
            ICategoryRepository categoryRepository)
        {
            _memoryCacheManager = memoryCacheManager;
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoriesDto>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            //if (!_memoryCacheManager.TryGetValue(nameof(GetCategoriesQuery), out IEnumerable<CategoriesDto> categoryDtos))
            //{
            //    categoryDtos = await _categoryRepository.GetCategoriesAsync(request.Criteria);

            //    _memoryCacheManager.Set(nameof(GetCategoriesQuery), categoryDtos);
            //}
            var categoryDtos = await _categoryRepository.GetCategoriesAsync(request.Criteria);

            return categoryDtos;
        }
    }
}
