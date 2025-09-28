using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Model;

public class EventFormModel
{
    [Required, StringLength(100, MinimumLength = 2)]
    public string? Name { get; set; }

    [Required]
    public DateTime? Date { get; set; }

    [Required, StringLength(200, MinimumLength = 2)]
    public string? Location { get; set; }

    [Required, StringLength(900)]
    public string? Description { get; set; }
}
