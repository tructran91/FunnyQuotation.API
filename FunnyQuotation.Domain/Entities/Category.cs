namespace FunnyQuotation.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public string Description { get; set; }

        public bool IsPublished { get; set; }

        public bool IsFavorite { get; set; }

        public string MetaTitle { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public string ThumbnailURL { get; set; }

        public List<Quotation> Quotations { get; set; }
    }
}
