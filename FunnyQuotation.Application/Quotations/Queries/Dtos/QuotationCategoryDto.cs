namespace FunnyQuotation.Application.Quotations.Queries.Dtos
{
    public class QuotationCategoryDto
    {
        public Guid QuotationId { get; set; }

        public List<Guid> CategoryId { get; set; }
    }
}
