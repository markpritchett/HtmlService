using System.ComponentModel.DataAnnotations;

namespace HtmlService.Views;

public class WelcomeEmailModelV1
{
    [Required] public string? FirstName { get; set; }

    [Required] public string? LastName { get; set; }
}

public class WelcomeEmailModelV2
{
    [Required] public string? FirstName { get; set; }

    [Required] public string? LastName { get; set; }

    [Required] public string? Occupation { get; set; }
}