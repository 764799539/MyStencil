using CRM.Contracts.EntityDto;
using CRM.Domain.Entity;
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

        public ProductAppService(
            IRepository<Product, Guid> productRepository
        ) : base(productRepository)
        {
            ProductRepository = productRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<string> dsadsa() {
            var dsa = await ProductRepository.ToListAsync();
            return "";
        }
    }
}
