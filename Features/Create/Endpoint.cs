using FastEndpoints;

public class MyEndpoint : EndpointWithoutRequest<Response>
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
