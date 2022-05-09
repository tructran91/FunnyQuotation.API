namespace FunnyQuotation.Application.Quotations.Queries.Dtos
{
    public class QuotationCriteriaDto
    {
        public Guid Id { get; set; }

        public int? CategoryId { get; set; }

        public string Slug { get; set; }

        public string AuthorId { get; set; }

        public QuotationStatusDto? Status { get; set; }

        public string Content { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public bool IsRandom { get; set; }
    }
}
