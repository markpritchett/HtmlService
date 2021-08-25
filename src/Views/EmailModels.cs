using System.ComponentModel.DataAnnotations;

namespace HtmlService.Views;

public class WelcomeEmailModelV1
{
    /// <summary>
    /// The first name of the customer
    /// </summary>
    /// <example>Mary</example>
    [Required] public string? FirstName { get; set; }

    /// <summary>
    /// The last name of the customer
    /// </summary>
    /// <example>Berry</example>
    [Required] public string? LastName { get; set; }
}

public class WelcomeEmailModelV2
{
    /// <summary>
    /// The first name of the customer
    /// </summary>
    /// <example>Mary</example>
    [Required] public string? FirstName { get; set; }

    /// <summary>
    /// The last name of the customer
    /// </summary>
    /// <example>Berry</example>
    [Required] public string? LastName { get; set; }

    /// <summary>
    /// The occupation of the customer
    /// </summary>
    /// <example>DevLopEr</example>
    [Required] public string? Occupation { get; set; }
}