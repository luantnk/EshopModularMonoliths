var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCatalogModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration)
    .AddBasketModule(builder.Configuration);
// Register custom services

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCatalogModule();
app.UseBasketModule();
app.UseOrderingModule();
// Use static files
app.UseStaticFiles();

// Use routing
app.UseRouting();

// Use authenthication
app.UseAuthentication();

// Use authorization
app.UseAuthorization();

// Define endpoints
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
