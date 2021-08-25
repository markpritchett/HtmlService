namespace HtmlService.Infrastructure;

public class Html
{
    private readonly IViewRenderService _viewRenderService;

    public Html(IViewRenderService viewRenderService) => _viewRenderService = viewRenderService;

    public async Task<IResult> Content(string viewName, object model)
    {
        var html = await _viewRenderService.RenderToStringAsync(viewName, model);
        return Results.Content(html, "text/html");
    }
}
