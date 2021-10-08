using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHtmlGeneration();
builder.Services.AddSwaggerWithVersions();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapApiRoutes();
app.UseSwaggerWithVersions();
app.Run();