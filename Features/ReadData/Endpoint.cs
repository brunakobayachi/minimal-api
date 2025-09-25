using FastEndpoints;

namespace Features.ReadData;
public class ReadData : EndpointWithoutRequest<Response>
{
    public override void Configure()
    {
        Get("/user");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        await Send.OkAsync(new Response()
        {
            Name = "Guppy",
            IsACat = true
        });
    }
}
