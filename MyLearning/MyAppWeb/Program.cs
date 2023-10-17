var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/map1", async (context) =>
    {
        await context.Response.WriteAsync("Hello world from map method");
    });

    endpoints.MapPost("/map2", async context => { await context.Response.WriteAsync("Hello from Map 2 post method"); });
});
app.Run(async (context) =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});
app.Run();
