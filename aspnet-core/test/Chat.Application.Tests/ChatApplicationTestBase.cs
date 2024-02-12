using Volo.Abp.Modularity;

namespace Chat;

public abstract class ChatApplicationTestBase<TStartupModule> : ChatTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
