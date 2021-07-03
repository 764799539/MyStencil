using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace CRM.EntityFrameworkCore
{
    [DependsOn(
        typeof(CRMEntityFrameworkCoreModule)
        )]
    public class CRMEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CRMMigrationsDbContext>();
        }
    }
}
