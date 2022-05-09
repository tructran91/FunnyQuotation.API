using AutoMapper;
using FunnyQuotation.Application.Categories.Queries.Dtos;
using FunnyQuotation.Application.Quotations.Queries.Dtos;
using FunnyQuotation.Domain.Entities;

namespace FunnyQuotation.Application.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Category

            CreateMap<Category, CategoriesDto>().ReverseMap();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>()
                .ForMember(d => d.Created, o =>
                {
                    o.PreCondition(s => s.Id == Guid.Empty);
                    o.MapFrom(s => DateTime.Now);
                })
               .ForMember(d => d.Updated, o =>
               {
                   o.PreCondition(s => s.Id != Guid.Empty);
                   o.MapFrom(s => DateTime.Now);
               });

            #endregion

            #region Quotation

            CreateMap<Quotation, QuotationDto>();
            CreateMap<QuotationDto, Quotation>()
                .ForMember(d => d.Created, o =>
                {
                    o.PreCondition(s => s.Id == Guid.Empty);
                    o.MapFrom(s => DateTime.Now);
                })
               .ForMember(d => d.Updated, o =>
               {
                   o.PreCondition(s => s.Id != Guid.Empty);
                   o.MapFrom(s => DateTime.Now);
               });

            #endregion
        }
    }
}
