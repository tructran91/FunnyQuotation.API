using AutoMapper;
using FunnyQuotation.Application.Categories.Queries.Dtos;
using FunnyQuotation.Application.Common.Interfaces.Repositories;
using FunnyQuotation.Domain.Entities;
using MediatR;

namespace FunnyQuotation.Application.Categories.Queries
{
    public class GetCategoryByIdQuery : IRequest<CategoryDto>
    {
        public Guid Id { get; set; }

        public GetCategoryByIdQuery(Guid id)
        {
            Id = id;
        }
    }

    public class GetCategoryByIdHandle : IRequestHandler<GetCategoryByIdQuery, CategoryDto>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryByIdHandle(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDto> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.Id);
            category = (category == null) ? new Category() : category;

            return _mapper.Map<CategoryDto>(category);
        }
    }
}
