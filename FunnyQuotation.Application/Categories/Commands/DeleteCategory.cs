using AutoMapper;
using FunnyQuotation.Application.Common.Interfaces.Repositories;
using FunnyQuotation.Domain.Entities;
using MediatR;

namespace FunnyQuotation.Application.Categories.Commands
{
    public class DeleteCategoryQuery : IRequest<string>
    {
        public Guid Id { get; set; }

        public DeleteCategoryQuery(Guid id)
        {
            Id = id;
        }
    }

    public class DeleteCategoryHandle : IRequestHandler<DeleteCategoryQuery, string>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public DeleteCategoryHandle(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<string> Handle(DeleteCategoryQuery request, CancellationToken cancellationToken)
        {
            var canDeleteCategory = await _categoryRepository.CanDeleteCategoryAsync(request.Id);
            if (!canDeleteCategory)
            {
                return "Danh mục này vẫn còn chứa câu trích dẫn. Không xóa được.";
            }
            await _categoryRepository.DeleteAsync(new Category { Id = request.Id });

            return string.Empty;
        }
    }
}
