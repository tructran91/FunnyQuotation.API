namespace FunnyQuotation.Application.Categories.Queries.Dtos
{
    public class CategoryCriteriaDto
    {
        public Guid Id { get; set; }

        public bool? IsPublished { get; set; }

        public bool? IsFavorite { get; set; }
    }
}
