
namespace FunnyQuotation.Domain.Entities
{
    public class Favorite
    {
        public Guid Id { get; set; }

        public Guid QuotationId { get; set; }

        public Quotation Quotation { get; set; }

        public Guid AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
