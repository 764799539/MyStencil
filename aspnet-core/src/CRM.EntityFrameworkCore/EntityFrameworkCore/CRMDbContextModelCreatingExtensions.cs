using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace CRM.EntityFrameworkCore
{
    public static class CRMDbContextModelCreatingExtensions
    {
        public static void ConfigureCRM(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(CRMConsts.DbTablePrefix + "YourEntities", CRMConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}