namespace HtmlService.Infrastructure.Swagger;

public static class ServiceCollectionExtensions
{
    public static void AddSwaggerWithVersions(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new() { Title = "HTML Service", Version = "v1" });
            c.SwaggerDoc("v2", new() { Title = "HTML Service", Version = "v2" });

            c.DocInclusionPredicate((version, desc) =>
            {
                return desc?.RelativePath?.StartsWith(version, StringComparison.InvariantCultureIgnoreCase) == true;
            });
        });
    }
}
