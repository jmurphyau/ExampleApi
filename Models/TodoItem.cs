using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExampleApi.Models;

public class TodoItem
{
    public long Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    [DefaultValue(false)]
    public bool IsComplete { get; set; }
}