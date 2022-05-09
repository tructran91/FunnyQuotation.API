using AutoMapper;
using FunnyQuotation.Application.Categories.Queries.Dtos;
using FunnyQuotation.Application.Common.Interfaces.Repositories;
using FunnyQuotation.Application.Common.Models;
using FunnyQuotation.Application.Infrastructure;
using FunnyQuotation.Domain.Entities;
using MediatR;

namespace FunnyQuotation.Application.Categories.Commands
{
    public class AddCategoryQuery : IRequest<Result<AddCategoryQuery>>
    {
        public CategoryDto Category { get; set; }

        public AddCategoryQuery(CategoryDto category)
        {
            Category = category;
        }
    }

    public class AddCategoryHandle : IRequestHandler<AddCategoryQuery, Result<AddCategoryQuery>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public AddCategoryHandle(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<Result<AddCategoryQuery>> Handle(AddCategoryQuery request, CancellationToken cancellationToken)
        {
            request.Category.Slug = request.Category.Name.Slugify();

            var originalCategory = await _categoryRepository.GetCategoryBySlugAsync(request.Category.Slug);
            if (originalCategory != null)
            {
                return Result<AddCategoryQuery>.Failure("Tên chủ đề đã tồn tại.", null);
            }

            var category = _mapper.Map<Category>(request.Category);

            var result = await _categoryRepository.AddAsync(category);
            request.Category.Id = result.Id;

            return Result<AddCategoryQuery>.Success(request); ;
        }
    }
}
