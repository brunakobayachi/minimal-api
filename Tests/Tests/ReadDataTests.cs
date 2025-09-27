using FastEndpoints.Testing;
using Shouldly;
using Features.ReadData;
using FastEndpoints;
using Xunit; 

namespace MyApi.Tests;

public class ReadDataTests(DefaultAppFixture app) : TestBase<DefaultAppFixture>
{
    [Fact]
    public async Task GET_user_returns_expected_payload()
    {
        var (rsp, res) = await app.Client.GETAsync<ReadData, Response>();

        rsp.IsSuccessStatusCode.ShouldBeTrue();
        res.ShouldNotBeNull();
        res!.Name.ShouldBe("Guppy");
        res.IsACat.ShouldBeTrue();
    }
}

