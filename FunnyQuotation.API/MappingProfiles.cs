using AutoMapper;
using FunnyQuotation.API.ViewModels;
using FunnyQuotation.Application.Categories.Queries.Dtos;

namespace FunnyQuotation.API
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CategoryDto, AddEditCategoryViewModel>().ReverseMap();
            //CreateMap<QuotationDto, AdminEditQuotationViewModel>().ReverseMap();
            //CreateMap<UserDto, AdminEditUserViewModel>().ReverseMap();
        }
    }
}
