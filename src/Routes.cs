namespace HtmlService;

public static class Routes
{
    public static void MapApiRoutes(this WebApplication app)
    {
        app.MapPost("v1/welcome-email", async (WelcomeEmailModelV1 model, Html html) =>
            await html.Content("WelcomeEmailV1", model));

        app.MapPost("v2/welcome-email", async (WelcomeEmailModelV2 model, Html html) =>
            await html.Content("WelcomeEmailV2", model));
    }
}
