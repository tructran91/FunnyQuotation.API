using System.ComponentModel.DataAnnotations;

namespace FunnyQuotation.Domain.Entities
{
    public class Quotation : BaseEntity
    {
        public string Content { get; set; }

        public string Slug { get; set; }

        public string MetaTitle { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public QuotationType Type { get; set; }

        public QuotationStatus Status { get; set; }

        public Category Category { get; set; }

        public Author Author { get; set; }
    }

    public enum QuotationStatus
    {
        [Display(Name = "Chờ duyệt")]
        Pending = 1,

        [Display(Name = "Đã kiểm duyệt")]
        Approved = 2,

        [Display(Name = "Từ chối")]
        Rejected = 3,
    }

    public enum QuotationType
    {
        [Display(Name = "Bình thường")]
        None = 0,

        [Display(Name = "Văn thơ")]
        Verse = 1,

        [Display(Name = "Tin nhắn")]
        Chat = 2,
    }
}
