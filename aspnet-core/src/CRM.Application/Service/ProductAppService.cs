using CRM.Contracts.EntityDto;
using CRM.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CRM.Service
{
    public class ProductAppService : CrudAppService<Product, ProductDto, Guid, ProductDto, ProductDto>
    {
        private readonly IRepository<Product, Guid> ProductRepository;
        private readonly IRepository<ProductDetail, Guid> ProductDetailRepository;

        public ProductAppService(
            IRepository<Product, Guid> productRepository,
            IRepository<ProductDetail, Guid> productDetailRepository
        ) : base(productRepository)
        {
            ProductRepository = productRepository;
            ProductDetailRepository = productDetailRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="InputDto"></param>
        /// <returns></returns>
        public async Task<ProductDetailDto> Test(ProductDetailDto InputDto) {
            var entity = ObjectMapper.Map<ProductDetailDto, ProductDetail>(InputDto);
            var Result = await ProductDetailRepository.InsertAsync(entity);




            await ProductDetailRepository.Where(sa => sa.Wide > 0).ToListAsync();









            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<ProductDetail, ProductDetailDto>(Result);
        }
    }
}
