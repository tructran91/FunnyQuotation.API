using System.ComponentModel.DataAnnotations;

namespace FunnyQuotation.Application.Quotations.Queries.Dtos
{
    public class QuotationDto
    {
        public Guid Id { get; set; }

        public string Content { get; set; }

        public Guid AuthorId { get; set; }

        public string AuthorName { get; set; }

        public QuotationStatusDto Status { get; set; }

        public QuotationTypeDto Type { get; set; }

        public string Slug { get; set; }

        public string MetaTitle { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public int TotalItems { get; set; }

        public List<int> SelectedCategoryIds { get; set; }
    }

    public enum QuotationStatusDto
    {
        [Display(Name = "Chờ duyệt")]
        Pending = 1,

        [Display(Name = "Đã kiểm duyệt")]
        Approved = 2,

        [Display(Name = "Từ chối")]
        Rejected = 3,
    }

    public enum QuotationTypeDto
    {
        [Display(Name = "Bình thường")]
        None = 0,

        [Display(Name = "Văn thơ")]
        Verse = 1,

        [Display(Name = "Tin nhắn")]
        Chat = 2,
    }
}
