namespace HtmlService.Infrastructure.Swagger;

public static class WebApplicationExtensions
{
    public static void UseSwaggerWithVersions(this WebApplication app)
    {
        app.UseSwagger();

        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            c.SwaggerEndpoint("/swagger/v2/swagger.json", "v2");
        });
    }
}
