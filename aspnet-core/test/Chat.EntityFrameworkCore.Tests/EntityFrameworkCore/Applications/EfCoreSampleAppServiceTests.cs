using Chat.Samples;
using Xunit;

namespace Chat.EntityFrameworkCore.Applications;

[Collection(ChatTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ChatEntityFrameworkCoreTestModule>
{

}
