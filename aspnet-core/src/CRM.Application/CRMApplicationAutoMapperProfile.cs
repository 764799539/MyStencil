using AutoMapper;
using CRM.Contracts.EntityDto;
using CRM.Domain.Entity;
using Volo.Abp.AutoMapper;

namespace CRM
{
    public class CRMApplicationAutoMapperProfile : Profile
    {
        public CRMApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>().IgnoreAuditedObjectProperties();

            CreateMap<ProductDetail, ProductDetailDto>();
            CreateMap<ProductDetailDto, ProductDetail>().IgnoreAuditedObjectProperties();
        }
    }
}
