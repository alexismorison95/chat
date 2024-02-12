using Chat.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Chat.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ChatEntityFrameworkCoreModule),
    typeof(ChatApplicationContractsModule)
    )]
public class ChatDbMigratorModule : AbpModule
{
}
