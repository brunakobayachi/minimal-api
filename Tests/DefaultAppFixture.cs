using FastEndpoints.Testing;
using Microsoft.AspNetCore.Hosting;

namespace MyApi.Tests;

public class DefaultAppFixture : AppFixture<Program>
{
    protected override void ConfigureApp(IWebHostBuilder builder)
        => builder.UseEnvironment("Testing");
}
