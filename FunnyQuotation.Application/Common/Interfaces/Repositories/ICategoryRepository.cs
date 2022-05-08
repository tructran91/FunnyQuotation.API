using FunnyQuotation.Application.Categories.Queries.Dtos;
using FunnyQuotation.Domain.Entities;

namespace FunnyQuotation.Application.Common.Interfaces.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetCategoryByIdAsync(Guid id);

        Task<Category> GetCategoryBySlugAsync(string slug);

        Task<CategoryDto> GetCategoryByQuotationAsync(string quotationSlug);

        public Task<List<CategoriesDto>> GetCategoriesAsync(CategoryCriteriaDto categoryCriteriaDto);

        Task<bool> CanDeleteCategoryAsync(Guid id);
    }
}
