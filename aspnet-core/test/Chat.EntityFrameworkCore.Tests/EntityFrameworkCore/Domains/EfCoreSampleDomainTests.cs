using Chat.Samples;
using Xunit;

namespace Chat.EntityFrameworkCore.Domains;

[Collection(ChatTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ChatEntityFrameworkCoreTestModule>
{

}
