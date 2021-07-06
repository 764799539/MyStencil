using CRM.Domain.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CRM.Contracts.EntityDto
{
    /// <summary>
    /// 产品明细DTO
    /// </summary>
    public class ProductDetailDto
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal Long { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Wide { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal High { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ProductDto Product { get; set; }
    }
}
