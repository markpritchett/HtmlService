namespace HtmlService.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static void AddHtmlGeneration(this IServiceCollection services)
    {
        services.AddControllersWithViews();
        services.AddScoped<IViewRenderService, ViewRenderService>();
        services.AddScoped<Html>();
    }
}
