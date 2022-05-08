using AutoMapper;
using FunnyQuotation.Application.Categories.Queries.Dtos;
using FunnyQuotation.Application.Common.Interfaces.Repositories;
using FunnyQuotation.Application.Infrastructure;
using FunnyQuotation.Domain.Entities;
using MediatR;

namespace FunnyQuotation.Application.Categories.Commands
{
    public class UpdateCategoryQuery : IRequest<string>
    {
        public CategoryDto Category { get; set; }

        public UpdateCategoryQuery(CategoryDto category)
        {
            Category = category;
        }
    }

    public class UpdateCategoryHandle : IRequestHandler<UpdateCategoryQuery, string>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public UpdateCategoryHandle(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<string> Handle(UpdateCategoryQuery request, CancellationToken cancellationToken)
        {
            request.Category.Slug = request.Category.Name.Slugify();

            var originalCategory = await _categoryRepository.GetCategoryByIdAsync(request.Category.Id);
            if (originalCategory == null)
            {
                return "Không tìm thấy chủ đề.";
            }
            originalCategory = await _categoryRepository.GetCategoryBySlugAsync(request.Category.Slug);
            if (originalCategory != null)
            {
                if (originalCategory.Id != request.Category.Id)
                {
                    return "Tên chủ đề này đã tồn tại.";
                }
            }

            var category = _mapper.Map<Category>(request.Category);
            await _categoryRepository.UpdateAsync(category);

            return string.Empty;
        }
    }
}
