using Microsoft.OpenApi.Models;
using HtmlService.Infrastructure;
using HtmlService.Infrastructure.Swagger;
using HtmlService.Views;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHtmlGeneration();
builder.Services.AddSwaggerWithVersions();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwaggerWithVersions();
app.UseHttpsRedirection();

app.MapPost("v1/welcome-email", async (WelcomeEmailModelV1 model, Html html) =>
            await html.Content("WelcomeEmailV1", model));

app.MapPost("v2/welcome-email", async (WelcomeEmailModelV2 model, Html html) =>
    await html.Content("WelcomeEmailV2", model));

app.Run();
