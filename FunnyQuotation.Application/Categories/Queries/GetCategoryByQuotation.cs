using AutoMapper;
using FunnyQuotation.Application.Categories.Queries.Dtos;
using FunnyQuotation.Application.Common.Interfaces.Repositories;
using MediatR;

namespace FunnyQuotation.Application.Categories.Queries
{
    public class GetCategoryByQuotationQuery : IRequest<CategoryDto>
    {
        public string QuotationSlug { get; set; }

        public GetCategoryByQuotationQuery(string quotationSlug)
        {
            QuotationSlug = quotationSlug;
        }
    }

    public class GetCategoryByQuotationHandle : IRequestHandler<GetCategoryByQuotationQuery, CategoryDto>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryByQuotationHandle(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDto> Handle(GetCategoryByQuotationQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetCategoryByQuotationAsync(request.QuotationSlug);
            category = (category == null) ? new CategoryDto() : category;

            return category;
        }
    }
}
