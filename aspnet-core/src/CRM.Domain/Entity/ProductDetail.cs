using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace CRM.Domain.Entity
{
    /// <summary>
    /// 产品明细实体
    /// </summary>
    public class ProductDetail : AuditedEntity<Guid>, ISoftDelete
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
        public Guid ProductID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Product Product { get; set; }

        public bool IsDeleted { get; set; }
    }
}
