using CRM.Contracts.EntityDto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace CRM.IService
{
    public interface IProductAppService : ICrudAppService<ProductDto, Guid, ProductDto, ProductDto>
    {

    }
}
