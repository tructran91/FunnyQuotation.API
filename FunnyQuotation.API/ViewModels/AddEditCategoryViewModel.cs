using System.ComponentModel.DataAnnotations;

namespace FunnyQuotation.API.ViewModels
{
    public class AddEditCategoryViewModel
    {
        public Guid? Id { get; set; }

        [Required]
        [Display(Name = "Tên chủ đề")]
        public string Name { get; set; }

        public string Slug { get; set; }

        [Required]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        [Display(Name = "Hiển thị ra website")]
        public bool IsPublished { get; set; }

        [Display(Name = "Nổi bật")]
        public bool IsFavorite { get; set; }

        [Display(Name = "Meta title")]
        public string MetaTitle { get; set; }

        [Display(Name = "Meta keywords")]
        public string MetaKeywords { get; set; }

        [Display(Name = "Meta description")]
        public string MetaDescription { get; set; }

        [Display(Name = "Thumbnail URL")]
        public string ThumbnailURL { get; set; }
    }
}
