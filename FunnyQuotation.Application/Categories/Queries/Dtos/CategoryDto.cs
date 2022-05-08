namespace FunnyQuotation.Application.Categories.Queries.Dtos
{
    public class CategoryDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string Description { get; set; }

        public bool IsPublished { get; set; }

        public bool IsFavorite { get; set; }

        public string MetaTitle { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public string ThumbnailURL { get; set; }
    }
}
