using Volo.Abp.Modularity;

namespace Chat;

[DependsOn(
    typeof(ChatDomainModule),
    typeof(ChatTestBaseModule)
)]
public class ChatDomainTestModule : AbpModule
{

}
