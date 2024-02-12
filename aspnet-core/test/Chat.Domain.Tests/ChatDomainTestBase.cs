using Volo.Abp.Modularity;

namespace Chat;

/* Inherit from this class for your domain layer tests. */
public abstract class ChatDomainTestBase<TStartupModule> : ChatTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
