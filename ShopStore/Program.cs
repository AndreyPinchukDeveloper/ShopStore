var builder = WebApplication.CreateBuilder(args);

void ConfigureServices(IServiceCollection services)
{
    services.AddMvc();
}
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
  