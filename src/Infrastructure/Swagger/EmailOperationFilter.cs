using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;

namespace HtmlService.Infrastructure.Swagger;

public class EmailOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        if (context.ApiDescription?.RelativePath?.Contains("Email", StringComparison.InvariantCultureIgnoreCase) == true)
        {
            operation.Responses.Add("400", new OpenApiResponse { Description = "Bad Request" });
        }
    }
}
