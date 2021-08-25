using System.ComponentModel.DataAnnotations;

namespace HtmlService.Infrastructure;

public class Html
{
    private readonly IViewRenderService _viewRenderService;

    public Html(IViewRenderService viewRenderService) => _viewRenderService = viewRenderService;

    public async Task<IResult> Content(string viewName, object model)
    {
        _ = !MinimalValidation.TryValidate(model, out var errors);

        if (errors.Any())
        {
            return Results.BadRequest(errors);
        }

        var html = await _viewRenderService.RenderToStringAsync(viewName, model);
        return Results.Content(html, "text/html");
    }
}
