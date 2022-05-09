using AutoMapper;
using FunnyQuotation.Application.Categories.Queries.Dtos;
using FunnyQuotation.Application.Common.Interfaces.Repositories;
using FunnyQuotation.Domain.Entities;
using FunnyQuotation.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FunnyQuotation.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private IMapper _mapper;

        public CategoryRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public async Task<Category> GetCategoryByIdAsync(Guid id)
        {
            return await _context.Categories
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<Category> GetCategoryBySlugAsync(string slug)
        {
            return await _context.Categories
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.Slug == slug);
        }

        public async Task<CategoryDto> GetCategoryByQuotationAsync(string quotationSlug)
        {
            var category = await _context.Quotations
                .Include(t => t.Category)
                .AsNoTracking()
                .Where(t => t.Slug == quotationSlug)
                .Select(t => t.Category)
                .FirstOrDefaultAsync();

            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<List<CategoriesDto>> GetCategoriesAsync(CategoryCriteriaDto criteria)
        {
            IQueryable<Category> query = _context.Categories.AsNoTracking();

            if (criteria.IsPublished.HasValue)
            {
                query = query.Where(t => t.IsPublished == criteria.IsPublished.Value);
            }
            if (criteria.IsFavorite.HasValue)
            {
                query = query.Where(t => t.IsFavorite == criteria.IsFavorite.Value);
            }
            if (criteria.Id != Guid.Empty)
            {
                query = query.Where(x => x.Id == criteria.Id);
            }
            var categories = await query.OrderBy(t => t.Name).ToListAsync();
            return _mapper.Map<List<CategoriesDto>>(categories);
        }

        public async Task<bool> CanDeleteCategoryAsync(Guid id)
        {
            var anyRecord = await _context.Quotations
                .AsNoTracking()
                .AnyAsync(t => t.Id == id);
            return !anyRecord;
        }
    }
}
