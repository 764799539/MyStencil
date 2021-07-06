using CRM.Domain.Shared.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CRM.Contracts.EntityDto
{
    /// <summary>
    /// 产品DTO
    /// </summary>
    public class ProductDto : AuditedEntityDto<Guid>
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [Required]
        public string Describe { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Required]
        public ProductType Type { get; set; }
    }
}
