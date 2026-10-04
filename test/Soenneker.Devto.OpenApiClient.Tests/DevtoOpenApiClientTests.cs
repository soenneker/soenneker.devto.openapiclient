using Soenneker.Tests.HostedUnit;

namespace Soenneker.Devto.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class DevtoOpenApiClientTests : HostedUnitTest
{
    public DevtoOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
